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
    public class TimekeepingProcess_BUS
    {
        public static KeyValuePair<bool, string> InsertMany(List<TimekeepingProcess_DTO> timekeeping)
        {
            return TimekeepingProcess_DAO.InsertMany(timekeeping);
        }

        public static KeyValuePair<bool, List<TimekeepingProcess_DTO>> GetMany(string command, Action<SqlCommand> cb)
        {
            return TimekeepingProcess_DAO.GetMany(command, cb);
        }
    }
}
