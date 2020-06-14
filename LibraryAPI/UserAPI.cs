﻿using MySql.Data.MySqlClient;
using MyMysql;
using System.Data;

namespace LibraryAPI
{
    static public class UserAPI
    {
        public struct UserDescription
        {
            public UserDescription(string username, string passwd, int sex, string contact)
            {
                this.username = username;
                this.passwd = passwd;
                this.sex = sex;
                this.contact = contact;
            }
            string username;
            string passwd;
            int sex;
            string contact;
        }
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
            if (result != 1)
            {
                return false;
            }
            return true;
        }
        #endregion
        #region 获取用户信息
        public static UserDescription GetUserDescription(MyMySql sql , string userid)
        {
            string sqlstr = $@"
SELECT username, userpassword, sex, contact
FROM users
WHERE userid = {userid}";
            DataRow row = sql.executeQueryFirst(sqlstr);
            return new UserDescription(row["username"].ToString(), row["password"].ToString(), int.Parse(row["sex"].ToString()), row["contact"].ToString());
        }
        #endregion

        public static DataTable GetAllUsers(MyMySql sql_users)
        {
            return sql_users.executeQuery(@"SELECT * FROM users");
        }

        #region UserInfo
        public class UserInfo
        {
            public readonly string userid;
            public readonly USER_TYPE type;
            public UserInfo(string userid, UserAPI.USER_TYPE type)
            {
                this.userid = userid;
                this.type = type;
            }
        }
        #endregion
    }
}
