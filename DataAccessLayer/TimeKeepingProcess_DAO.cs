using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static DataTransferObject.DataTransferObject;

namespace DataAccessLayer
{
    public class TimekeepingProcess_DAO
    {
        public static KeyValuePair<bool, string> InsertMany(List<TimekeepingProcess_DTO> timekeeping)
        {
            return DataProvider.Instance().InsertMany("TimekeepingProcess", timekeeping);
        }
        
        public static KeyValuePair<bool, List<TimekeepingProcess_DTO>> GetMany(string command, Action<SqlCommand> cb)
        {
            return DataProvider.Instance().GetMany<TimekeepingProcess_DTO>(command, cb);
        }

        public static KeyValuePair<bool, string> UpsertMany(List<TimekeepingProcess_DTO> timekeepings)
        {
            if (timekeepings.Count == 0)
                return new KeyValuePair<bool, string>(true, "");

            string command_builder = "merge TimekeepingProcess using (values";

            for (int i = 0; i < timekeepings.Count; ++i)
            {
                command_builder += "(";
                TimekeepingProcess_DTO obj = timekeepings[i];
                foreach(PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (prop.Name == "id") continue;

                    command_builder += "@" + prop.Name + "_" + i + ",";
                }

                command_builder = command_builder.Remove(command_builder.Length - 1);
                command_builder += "),";
            }

            command_builder = command_builder.Remove(command_builder.Length - 1);
            command_builder += ") src(staff_info_id, timekeeping_date, timekeeping_status, evaluated_by_id) on TimekeepingProcess.timekeeping_date = src.timekeeping_date when matched then update set TimekeepingProcess.timekeeping_status = src.timekeeping_status when not matched then insert values(src.staff_info_id, src.timekeeping_date, src.timekeeping_status, src.evaluated_by_id);";

            return DataProvider.Instance().CrudQuery(command_builder, sqlCommand =>
            {
                for (int i = 0; i < timekeepings.Count; ++i)
                {
                    TimekeepingProcess_DTO obj = timekeepings[i];
                    foreach(PropertyInfo prop in obj.GetType().GetProperties())
                    {
                        sqlCommand.Parameters.AddWithValue("@" + prop.Name + "_" + i, prop.GetValue(obj, null));
                    }
                }
            });
        }
    }
}
