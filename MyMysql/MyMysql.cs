using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MyMysql
{
    public class MyMySql
    {
        private MySqlConnection connection = null;
        string username = "";
        string password = "";
        string database = "";
        string port = "";
        string charset = "";
        string host = "";

        public MyMySql(string database, string password, string username = "root", string host = "localhost", string port = "3306", string charset = "UTF8")
        {
            this.database = database;
            this.username = username.Equals("") ? "root" : username;
            this.password = password;
            this.port = port.Equals("") ? "3306" : port;
            this.charset = charset;
            this.host = host.Equals("") ? "localhost" : host;
        }

        public string getConnectionString()
        {
            return $"username = {username}; password = {password}; port = {port}; database = {database}; charset = {charset}; server = {host}";
        }

        #region executeNonQuery
        public int executeNonQuery(string sqlstr)
        {
            Console.WriteLine(sqlstr);
            int count = 0;
            try
            {
                if (connection == null)
                {
                    connection = new MySqlConnection(getConnectionString());
                }
                connection.Open();
                count = new MySqlCommand(sqlstr, connection).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                TryClose();
            }
            return count;
        }
        #endregion
        #region executeQuery
        public DataTable executeQuery(string sqlstr)
        {
            Console.WriteLine(sqlstr);
            DataTable table = new DataTable();
            try
            {
                if (connection == null)
                {
                    connection = new MySqlConnection(getConnectionString());
                }
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlstr, this.connection);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                TryClose();
            }
            return table;
        }
        #endregion
        #region executeReader
        public MySqlDataReader executeReader(string sqlstr)
        {
            Console.WriteLine(sqlstr);
            try
            {
                if (connection == null)
                {
                    connection = new MySqlConnection(getConnectionString());
                }
                connection.Open();
                MySqlCommand command = new MySqlCommand(sqlstr, connection);
                MySqlDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        #endregion

        #region TryClose
        public void TryClose()
        {
            try
            {
                connection.Close();
            }
            catch { }
        }
        #endregion

        #region 尝试连接
        public bool tryConnect()
        {
            try
            {
                if (connection == null)
                {
                    connection = new MySqlConnection(getConnectionString());
                }
                connection.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
            finally
            {
                TryClose();
            }
        }
        #endregion
    }
}
