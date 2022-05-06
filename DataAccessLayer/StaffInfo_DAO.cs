using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataTransferObject.DataTransferObject;

namespace DataAccessLayer
{
    public class StaffInfo_DAO
    {
        public static KeyValuePair<bool, string> DeleteOne(int id)
        {
            return DataProvider.Instance().DeleteOne("StaffInfo", id);
        }

        public static KeyValuePair<bool, string> DeleteMany(List<int> list_int)
        {
            return DataProvider.Instance().DeleteMany("StaffInfo", list_int);
        }

        public static KeyValuePair<bool, List<StaffInfo_DTO>> GetMany()
        {
            return DataProvider.Instance().GetMany<StaffInfo_DTO>("StaffInfo");
        }

        public static KeyValuePair<bool, List<StaffInfo_DTO>> GetMany<V>(string key, V value)
        {
            return DataProvider.Instance().GetMany<StaffInfo_DTO, V>("StaffInfo", key, value);
        }

        public static KeyValuePair<bool, StaffInfo_DTO> GetOne(int id)
        {
            return DataProvider.Instance().GetOne<StaffInfo_DTO>("StaffInfo", id);
        }

        public static KeyValuePair<bool, string> UpdateOne(StaffInfo_DTO detail)
        {
            return DataProvider.Instance().UpdateOne<StaffInfo_DTO>("StaffInfo", detail);
        }

        public static KeyValuePair<bool, string> InsertOne(StaffInfo_DTO detail)
        {
            return DataProvider.Instance().InsertOne<StaffInfo_DTO>("StaffInfo", detail);
        }

        public static KeyValuePair<bool, List<StaffInfo_Display_DTO>> GetMany(string command, Action<SqlCommand> cb)
        {
            return DataProvider.Instance().GetMany<StaffInfo_Display_DTO>(command, cb);
        }
    }
}
