using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Specialized;
using log4net;
using log4net.Config;
using System.Diagnostics;
using System.Reflection;

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
                    UtilityLayer.Logging.Instance().LogInfo("[CRUD]: " + sqlCommand.CommandText);
                }

                return new KeyValuePair<bool, string>(true, "");
            }
            catch (Exception ex)
            {
                return new KeyValuePair<bool, string>(false, ex.Message);
            }
        }

        public Tuple<bool, string, DataTable> CrudQueryCount(string command, Action<SqlCommand> cb)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(_connectionString))
                {
                    sqlConn.Open();
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand sqlCommand = new SqlCommand(command, sqlConn);
                    cb(sqlCommand);

                    da.SelectCommand = sqlCommand;
                    da.Fill(dt);

                    return new Tuple<bool, string, DataTable>(true, "", dt);
                }
            }
            catch(Exception ex)
            {
                return new Tuple<bool, string, DataTable>(false, ex.Message, null);
            }
        }

        public KeyValuePair<bool, string> DeleteOne(string table_name, int id)
        {
            return CrudQuery("delete from @table where id=@id", sqlCommand =>
            {
                sqlCommand.Parameters.AddWithValue("@table", table_name);
                sqlCommand.Parameters.AddWithValue("@id", id);
            });
        }

        public KeyValuePair<bool, string> DeleteMany(string table_name, List<int> list_id)
        {
            string command_builder = "delete from " + table_name + " where ";

            for (int i = 0; i < list_id.Count; i++)
            {
                command_builder += " id=@id_" + i.ToString() + " or";
            }

            command_builder = command_builder.Remove(command_builder.Length - 2, 2);

            return CrudQuery(command_builder, sqlCommand =>
            {
                for (int i = 0; i < list_id.Count; ++ i)
                {
                    sqlCommand.Parameters.AddWithValue("@id_" + i.ToString(), list_id[i]);
                }
            });
        }

        public KeyValuePair<bool, string> InsertOne<T>(string table, T obj)
        {
            string command_builder = "insert into " + table + " values(";
            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                if (prop.Name == "id") continue;
                command_builder += ("@" + prop.Name + ",");
            }

            command_builder = command_builder.Remove(command_builder.Length - 1);
            command_builder += ")";

            return CrudQuery(command_builder, sqlCommand =>
            {
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    sqlCommand.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(obj, null));
                }
            });
        }

        public Tuple<bool, string, int> InsertOneCount<T>(string table, T obj)
        {
            string command_builder = "insert into " + table + " output inserted.id values(";

            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                if (prop.Name == "id") continue;
                command_builder += ("@" + prop.Name + ",");
            }

            command_builder = command_builder.Remove(command_builder.Length - 1);
            command_builder += ")";

            Tuple<bool, string, DataTable> dt = CrudQueryCount(command_builder, sqlCommand =>
            {
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    sqlCommand.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(obj, null));
                }
            });

            if (!dt.Item1)
            {
                return new Tuple<bool, string, int>(false, dt.Item2, 0);
            }

            if (dt.Item3.Rows.Count != 1)
            {
                return new Tuple<bool, string, int>(false, "Lỗi", 0);
            }

            return new Tuple<bool, string, int>(true, "", Int32.Parse(dt.Item3.Rows[0]["id"].ToString()));
        }

        public KeyValuePair<bool, string> InsertMany<T>(string table, List<T> list)
        {
            string command_builder = "insert into " + table + " values ";
            Action<SqlCommand> dlgate = sqlCommand => { };

            int count = 0;
            list.ForEach(item =>
            {
                command_builder += "(";
                foreach (PropertyInfo prop in item.GetType().GetProperties())
                {
                    if (prop.Name == "id") continue;
                    command_builder += ("@" + prop.Name + count + ",");
                    int index = count;
                    dlgate += sqlCommand => sqlCommand.Parameters.AddWithValue("@" + prop.Name + index, prop.GetValue(item, null));
                }

                ++count;

                command_builder = command_builder.Remove(command_builder.Length - 1);
                command_builder += "),";
            });

            command_builder = command_builder.Remove(command_builder.Length - 1);

            return CrudQuery(command_builder, dlgate);
        }

        public KeyValuePair<bool, string> UpdateOne<T>(string table_name, T obj)
        {
            string command_builder = "update " + table_name + " set ";

            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                if (prop.Name == "id") continue;
                command_builder += (prop.Name + "=@" + prop.Name + ",");
            }

            command_builder = command_builder.Remove(command_builder.Length - 1);
            command_builder += " where id=@id";

            return CrudQuery(command_builder, sqlCommand =>
            {
                foreach(PropertyInfo prop in obj.GetType().GetProperties())
                {
                    sqlCommand.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(obj, null));
                }
            });
        }

        public KeyValuePair<bool, T> GetOne<T>(string table_name, int id) where T : new()
        {
            string command_builder = "select * from " + table_name + " where id=@id";
            DataTable dt = GetDataTable(command_builder, sqlCommand =>
            {
                sqlCommand.Parameters.AddWithValue("@id", id);
            });

            T obj = new T();
            if (dt.Rows.Count != 1) return new KeyValuePair<bool, T>(false, obj);
            DataRow dr = dt.Rows[0];
            try
            {
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    prop.SetValue(obj, dr[prop.Name]);
                }
            }
            catch (Exception ex)
            {
                UtilityLayer.Logging.Instance().LogInfo("Error: [DataProvider][GetOne]: " + ex.Message);
            }

            return new KeyValuePair<bool, T>(true, obj);
        }

        public KeyValuePair<bool, T> GetOne<T, V>(string table_name, string key, V value) where T : new()
        {
            string command_builder = "select * from " + table_name + " where " + key + "=@" + key;
            DataTable dt = GetDataTable(command_builder, sqlCommand =>
            {
                sqlCommand.Parameters.AddWithValue("@" + key, value);
            });

            T obj = new T();
            if (dt.Rows.Count != 1) return new KeyValuePair<bool, T>(false, obj);
            DataRow dr = dt.Rows[0];
            try
            {
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    prop.SetValue(obj, dr[prop.Name]);
                }
            }
            catch (Exception ex)
            {
                UtilityLayer.Logging.Instance().LogInfo("Error: [DataProvider][GetOne]: " + ex.Message);
            }

            return new KeyValuePair<bool, T>(true, obj);
        }

        public KeyValuePair<bool, List<T>> GetMany<T>(string table_name) where T : new()
        {
            string command_builder = "select * from " + table_name;
            DataTable dt = GetDataTable(command_builder, sqlCommand =>
            {

            });

            List<T> list = new List<T>();

            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    T obj = new T();
                    foreach (PropertyInfo prop in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                    {
                        prop.SetValue(obj, dr[prop.Name]);
                    }

                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                UtilityLayer.Logging.Instance().LogInfo("Error: [DataProvider][GetMany]: " + ex.Message);
            }
            

            return new KeyValuePair<bool, List<T>>(true, list);
        }

        public KeyValuePair<bool, List<T>> GetMany<T, V>(string table_name, string key, V value) where T : new()
        {
            string command_builder = "select * from " + table_name + " where " + key + "=@" + key;
            DataTable dt = GetDataTable(command_builder, sqlCommand =>
            {
                sqlCommand.Parameters.AddWithValue("@" + key, value);
            });

            List<T> list = new List<T>();

            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    T obj = new T();
                    foreach (PropertyInfo prop in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                    {
                        prop.SetValue(obj, dr[prop.Name]);
                    }

                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                UtilityLayer.Logging.Instance().LogInfo("Error: [DataProvider][GetMany]: " + ex.Message);
            }


            return new KeyValuePair<bool, List<T>>(true, list);
        }

        public KeyValuePair<bool, List<T>> GetMany<T>(string command, Action<SqlCommand> cb) where T : new()
        {
            DataTable dt = GetDataTable(command, cb);
            List<T> list = new List<T>();

            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    T obj = new T();
                    foreach (PropertyInfo prop in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
                    {
                        prop.SetValue(obj, dr[prop.Name]);
                    }

                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                UtilityLayer.Logging.Instance().LogInfo("Error: [DataProvider][GetMany]: " + ex.Message);
            }

            return new KeyValuePair<bool, List<T>>(true, list);
        }

        public KeyValuePair<bool, int> Count(string table_name, string key, string value)
        {
            string command_builder = "select count(*) as count from " + table_name + " where " + key + "=@" + key;

            DataTable dt = GetDataTable(command_builder, sqlCommand =>
            {
                sqlCommand.Parameters.AddWithValue("@" + key, value);
            });

            if (dt.Rows.Count == 0) return new KeyValuePair<bool, int>(false, 0);

            return new KeyValuePair<bool, int>(true, Int32.Parse(dt.Rows[0]["count"].ToString()));
        }
    }
}
