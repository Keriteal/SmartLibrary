using MySql.Data.MySqlClient;
using MyMysql;

namespace LibraryAPI
{
    static public class UserAPI
    {
        public enum USER_TYPE
        {
            READER, ADMIN, INVAILD
        }
        public enum USER_SEX
        {
            FEMALE, MALE
        }

        #region 验证用户信息
        static public UserInfo Confirm(string username, string password, MyMysql.MyMySql sql)
        {
            string passwd = EncryptionUtils.getMD5(password).ToUpper();
            MySqlDataReader reader = sql.executeReader($"SELECT userid,userprivillege FROM users WHERE username = '{username}' AND password = '{passwd}'");
            if (reader != null)
            {
                UserInfo info = null;
                if (reader.Read())
                {
                    info = new UserInfo(reader["userid"].ToString(), (USER_TYPE)int.Parse(reader["userprivillege"].ToString()));
                }
                reader.Close();
                sql.TryClose();
                if (info != null)
                {
                    return info;
                }
            }
            return new UserInfo("", USER_TYPE.INVAILD);
        }
        #endregion
        #region 修改用户信息
        static public bool changeUserInfo(MyMySql mysql, string userid, string username = "", string password = "")
        {
            string passwd = EncryptionUtils.getMD5(password).ToUpper();
            string SQLstr = "UPDATE users SET " +
                (username.Equals("") ? "" : $"username = '{username}',") +
                (password.Equals("") ? "" : $"password = '{passwd.ToUpper()}'") +
                $"WHERE userid = {userid}";
            int result = mysql.executeNonQuery(SQLstr);
            if(result != 1)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region UserInfo
        public class UserInfo
        {
            public string userid;
            public USER_TYPE type;
            public UserInfo(string userid, UserAPI.USER_TYPE type)
            {
                this.userid = userid;
                this.type = type;
            }
        }
        #endregion
    }
}
