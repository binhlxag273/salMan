﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
    }
}
