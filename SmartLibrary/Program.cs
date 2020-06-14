using LibraryAPI;
using MyMysql;
using System;
using System.Windows.Forms;

namespace SmartLibrary
{
    static class Program
    {
        public static MyMySql books;
        public static MyMySql users;
        public static MyMySql other;
        public static UserAPI.UserInfo userinfo;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}
