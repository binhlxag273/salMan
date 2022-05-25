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
    public class SalaryProcess_DAO
    {
        public static KeyValuePair<bool, string> DeleteOne(int id)
        {
            return DataProvider.Instance().DeleteOne("SalaryProcess", id);
        }

        public static KeyValuePair<bool, string> DeleteMany(List<int> list_int)
        {
            return DataProvider.Instance().DeleteMany("SalaryProcess", list_int);
        }

        public static KeyValuePair<bool, List<SalaryProcess_DTO>> GetMany()
        {
            return DataProvider.Instance().GetMany<SalaryProcess_DTO>("SalaryProcess");
        }

        public static KeyValuePair<bool, List<SalaryProcess_DTO>> GetMany<V>(string key, V value)
        {
            return DataProvider.Instance().GetMany<SalaryProcess_DTO, V>("SalaryProcess", key, value);
        }

        public static KeyValuePair<bool, SalaryProcess_DTO> GetOne(int id)
        {
            return DataProvider.Instance().GetOne<SalaryProcess_DTO>("SalaryProcess", id);
        }

        public static KeyValuePair<bool, string> UpdateOne(SalaryProcess_DTO detail)
        {
            return DataProvider.Instance().UpdateOne("SalaryProcess", detail);
        }

        public static KeyValuePair<bool, string> InsertOne(SalaryProcess_DTO detail)
        {
            return DataProvider.Instance().InsertOne("SalaryProcess", detail);
        }

        public static KeyValuePair<bool, List<SalaryProcess_Display_DTO>> GetMany(string command, Action<SqlCommand> cb)
        {
            return DataProvider.Instance().GetMany<SalaryProcess_Display_DTO>(command, cb);
        }

        public static KeyValuePair<bool, string> InsertIfNotExist<T>(T obj, string key, string value)
        {
            string command_builder = "if not exists (select * from SalaryProcess where " + key + "=@" + key + ") begin insert into SalaryProcess values(";

            foreach(PropertyInfo prop in obj.GetType().GetProperties())
            {
                if (prop.Name == "id") continue;

                command_builder += "@" + prop.Name + ",";
            }

            command_builder = command_builder.Remove(command_builder.Length - 1);

            command_builder += ") end";

            return DataProvider.Instance().CrudQuery(command_builder, sqlCommand =>
            {

                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (prop.Name == key)
                    {
                        sqlCommand.Parameters.AddWithValue(key, value);
                        continue;
                    }

                    sqlCommand.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(obj, null));
                }

            });
        }
    }
}
