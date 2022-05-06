using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataTransferObject.DataTransferObject;

namespace BussinessLogicLayer
{
    public class Account_BUS
    {
        public static KeyValuePair<bool, Account_DTO> GetOne(string key, string value)
        {
            return DataAccessLayer.Account_DAO.GetOne<string>(key, value);
        }

        public static KeyValuePair<bool, List<Account_DTO>> GetMany()
        {
            return DataAccessLayer.Account_DAO.GetMany();
        }

        public static KeyValuePair<bool, List<Account_Display_DTO>> GetManyDisplay()
        {
            return DataAccessLayer.Account_DAO.GetMany("select acc.*, cd_1.name as account_type_ext, cd_2.name as group_type_ext from Account as acc, CategoryDetail as cd_1, CategoryDetail as cd_2 where acc.account_type_id = cd_1.id and acc.group_type_id = cd_2.id", sqlCommand =>
            {

            });
        }

        public static KeyValuePair<bool, string> InsertOne(Account_DTO account)
        {
            return DataAccessLayer.Account_DAO.InsertOne(account);
        }

        public static KeyValuePair<bool, string> UpdateOne(Account_DTO account)
        {
            return DataAccessLayer.Account_DAO.UpdateOne(account);
        }

        public static KeyValuePair<bool, string> DeleteMany(List<int> list_id)
        {
            return DataAccessLayer.Account_DAO.DeleteMany(list_id);
        }

        public static KeyValuePair<bool, int> Count(string account_name)
        {
            return DataAccessLayer.Account_DAO.Count("account_name", account_name);
        }

        public static Tuple<bool, string, int> InsertOneCount(Account_DTO account)
        {
            return DataAccessLayer.Account_DAO.InsertOneCount(account);
        }
    }
}
