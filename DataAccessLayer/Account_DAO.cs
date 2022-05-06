using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataTransferObject.DataTransferObject;

namespace DataAccessLayer
{
    public class Account_DAO
    {
        public static KeyValuePair<bool, Account_DTO> GetOne<T>(string key, T value)
        {
            return DataProvider.Instance().GetOne<Account_DTO, T>("Account", key, value);
        }

        public static KeyValuePair<bool, List<Account_DTO>> GetMany()
        {
            return DataProvider.Instance().GetMany<Account_DTO>("Account");
        }

        public static KeyValuePair<bool, string> InsertOne(Account_DTO account)
        {
            return DataProvider.Instance().InsertOne<Account_DTO>("Account", account);
        }

        public static KeyValuePair<bool, string> UpdateOne(Account_DTO account)
        {
            return DataProvider.Instance().UpdateOne<Account_DTO>("Account", account);
        }

        public static KeyValuePair<bool, List<Account_Display_DTO>> GetMany(string command, Action<SqlCommand> cb)
        {
            return DataProvider.Instance().GetMany<Account_Display_DTO>(command, cb);
        }

        public static KeyValuePair<bool, string> DeleteMany(List<int> list_id)
        {
            return DataProvider.Instance().DeleteMany("Account", list_id);
        }

        public static KeyValuePair<bool, int> Count(string key, string value)
        {
            return DataProvider.Instance().Count("Account", key, value);
        }

        public static Tuple<bool, string, int> InsertOneCount(Account_DTO account)
        {
            return DataProvider.Instance().InsertOneCount<Account_DTO>("Account", account);
        }
    }
}
