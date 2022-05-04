using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Specialized;
using log4net;
using log4net.Config;

namespace DataAccessLayer
{
    class DataProvider
    {
        private string _GetConnectionString()
        {

            string connectionString = "";
            var section = ConfigurationManager.GetSection("SqlConnection") as NameValueCollection;
            string host = section["host"];
            string port = section["port"];
            string initDb = section["initDb"];
            string username = section["username"];
            string password = section["password"];

            if (String.IsNullOrEmpty(host) || String.IsNullOrEmpty(port) || String.IsNullOrEmpty(initDb) || String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                return connectionString;
            }

            connectionString = //
                                "Data Source=" + host + "," + port + ";" +
                                "Initial Catalog=" + initDb + ";" +
                                "User id=" + username + ";" +
                                "Password=" + password + ";";

            return @connectionString;
        }

        private DataProvider()
        {
            _connectionString = _GetConnectionString();
        }

        private static DataProvider _instance;
        private string _connectionString = "";

        public static DataProvider Instance()
        {
            if (_instance == null)
            {
                _instance = new DataProvider();
            }

            return _instance;
        }

        public DataTable GetDataTable(string command, Action<SqlCommand> cb)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(_connectionString))
                {
                    sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand sqlCommand = new SqlCommand(command, sqlCon);
                    cb(sqlCommand);

                    da.SelectCommand = sqlCommand;
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {

            }

            return dt;
        }

        public KeyValuePair<bool, string> CrudQuery(string command, Action<SqlCommand> cb)
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(_connectionString))
                {
                    sqlConn.Open();
                    SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
                    cb(sqlCommand);
                    sqlCommand.ExecuteNonQuery();
                }

                return new KeyValuePair<bool, string>(true, "");
            }
            catch (Exception ex)
            {
                return new KeyValuePair<bool, string>(false, "Lỗi kết nối");
            }
        }
    }
}
