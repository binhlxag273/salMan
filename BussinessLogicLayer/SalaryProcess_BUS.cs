using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataTransferObject.DataTransferObject;

namespace BussinessLogicLayer
{
    public class SalaryProcess_BUS
    {
        public static KeyValuePair<bool, string> DeleteMany(List<int> list_int)
        {
            return SalaryProcess_DAO.DeleteMany(list_int);
        }

        public static KeyValuePair<bool, string> DeleteOne(int id)
        {
            return SalaryProcess_DAO.DeleteOne(id);
        }

        public static KeyValuePair<bool, List<SalaryProcess_DTO>> GetMany()
        {
            return SalaryProcess_DAO.GetMany();
        }

        public static KeyValuePair<bool, List<SalaryProcess_DTO>> GetMany<T>(string key, T value)
        {
            return SalaryProcess_DAO.GetMany<T>(key, value);
        }

        public static KeyValuePair<bool, SalaryProcess_DTO> GetOne(int id)
        {
            return SalaryProcess_DAO.GetOne(id);
        }

        public static KeyValuePair<bool, string> UpdateOne(SalaryProcess_DTO detail)
        {
            return SalaryProcess_DAO.UpdateOne(detail);
        }

        public static KeyValuePair<bool, string> InsertOne(SalaryProcess_DTO detail)
        {
            return SalaryProcess_DAO.InsertOne(detail);
        }

        public static KeyValuePair<bool, List<SalaryProcess_Display_DTO>> GetManyDisplayCommand(string command, Action<SqlCommand> cb)
        {
            return SalaryProcess_DAO.GetMany(command, cb);
        }
    }
}
