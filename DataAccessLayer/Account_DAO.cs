using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataTransferObject.DataTransferObject;

namespace DataAccessLayer
{
    public class Account_DAO
    {
        public static KeyValuePair<bool, Account_DTO> GetOneAccount(string account_name)
        {
            DataTable dt = DataProvider.Instance().GetDataTable("select * from Account where account_name=@account_name", sqlCommand =>
            {
                sqlCommand.Parameters.AddWithValue("@account_name", account_name);
            });

            Account_DTO account = new Account_DTO();
            if (dt.Rows.Count != 1)
            {
                return new KeyValuePair<bool, Account_DTO> (false, account);
            }

            DataRow dr = dt.Rows[0];
            account.account_name = dr["account_name"].ToString();
            account.password = dr["Password"].ToString();

            return new KeyValuePair<bool, Account_DTO>(true, account);
        }

        public static List<Account_DTO> GetManyAccount()
        {
            DataTable dt = DataProvider.Instance().GetDataTable("select * from Account", sqlCommand =>
            {

            });

            List<Account_DTO> result = new List<Account_DTO> ();

            foreach (DataRow dr in dt.Rows)
            {
                Account_DTO account = new Account_DTO();
                account.account_name = dr["account_name"].ToString();
                account.password = dr["password"].ToString();
                account.account_type_id = Int32.Parse(dr["account_type_id"].ToString());
                account.group_type_id = Int32.Parse(dr["group_type_id"].ToString());
                account.validated = Boolean.Parse(dr["validated"].ToString());
                account.blocked = Boolean.Parse(dr["blocked"].ToString());

                result.Add(account);
            }

            return result;
        }

        public static KeyValuePair<bool, string> AddOneAccount(Account_DTO account)
        {
            return DataProvider.Instance().CrudQuery("insert into Account values(@account_name, @password, @account_type_id, @group_type_id, @validated, @blocked)", sqlCommand =>
            {
                sqlCommand.Parameters.AddWithValue("@account_name", account.account_name);
                sqlCommand.Parameters.AddWithValue("@password", account.password);
                sqlCommand.Parameters.AddWithValue("@account_type_id", account.account_type_id);
                sqlCommand.Parameters.AddWithValue("@group_type_id", account.group_type_id);
                sqlCommand.Parameters.AddWithValue("@validated", account.validated);
                sqlCommand.Parameters.AddWithValue("@blocked", account.blocked);
            });
        }

        public static KeyValuePair<bool, string> UpdateOneAccount(Account_DTO account)
        {
            return DataProvider.Instance().CrudQuery("update Account set password=@password, account_type_id=@account_type_id, group_type_id=@group_type_id, validated=@validated, blocked=@blocked where account_name=@account_name", sqlCommand =>
            {
                sqlCommand.Parameters.AddWithValue("@password", account.password);
                sqlCommand.Parameters.AddWithValue("@account_type_id", account.account_type_id);
                sqlCommand.Parameters.AddWithValue("@group_type_id", account.group_type_id);
                sqlCommand.Parameters.AddWithValue("@validated", account.validated);
                sqlCommand.Parameters.AddWithValue("@blocked", account.blocked);
                sqlCommand.Parameters.AddWithValue("@account_name", account.account_name);
            });
        }
    }
}
