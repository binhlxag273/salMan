using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            return DataProvider.Instance().UpdateOne<SalaryProcess_DTO>("SalaryProcess", detail);
        }

        public static KeyValuePair<bool, string> InsertOne(SalaryProcess_DTO detail)
        {
            return DataProvider.Instance().InsertOne<SalaryProcess_DTO>("SalaryProcess", detail);
        }

        public static KeyValuePair<bool, List<SalaryProcess_Display_DTO>> GetMany(string command, Action<SqlCommand> cb)
        {
            return DataProvider.Instance().GetMany<SalaryProcess_Display_DTO>(command, cb);
        }
    }
}
