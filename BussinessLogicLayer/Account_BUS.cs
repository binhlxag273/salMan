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
        public static KeyValuePair<bool, string> LogOut(string account_name)
        {
            bool ok = true;
            string error_string = "";


            UtilityLayer.Logging.Instance().LogInfo("Log auth [Logout]: " + account_name);

            return new KeyValuePair<bool, string> (ok, error_string);
        }

        public static KeyValuePair<bool, Account_DTO> GetOneAccount(string account_name)
        {
            return DataAccessLayer.Account_DAO.GetOneAccount(account_name);
        }

        public static List<Account_DTO> GetManyAccount()
        {
            return DataAccessLayer.Account_DAO.GetManyAccount();
        }

        public static KeyValuePair<bool, string> AddOneAccount(Account_DTO account)
        {
            return DataAccessLayer.Account_DAO.AddOneAccount(account);
        }

        public static KeyValuePair<bool, string> UpdateOneAccount(Account_DTO account)
        {
            return DataAccessLayer.Account_DAO.UpdateOneAccount(account);
        }            
    }
}
