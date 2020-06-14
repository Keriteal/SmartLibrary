using System;
using System.Windows.Forms;
using LibraryAPI;
using MyMysql;

namespace SmartLibrary
{
    public partial class LoginDialog : Form
    {
        bool isLogedIn = false;
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserAPI.UserInfo info = UserAPI.Confirm(UserName.Text, UserPassword.Text, Program.users);
            if (info.type != UserAPI.USER_TYPE.INVAILD)
            {
                Program.userinfo = info;
                ((MainMenu)Owner).onGetUserInfo(info);
                MessageBox.Show("登陆成功");
                isLogedIn = true;
                Close();
            }
            else
            {
                MessageBox.Show("错误");
            }
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            Hide();
            new RegistDialog().ShowDialog();
            Show();
        }

        private void LoginDialog_Load(object sender, EventArgs e)
        {
            string dbuser = Util.Read("dbuser");
            string dbpass = EncryptionUtils.aesDecryptBase64(Util.Read("dbpass"), EncryptionUtils.DEFAULT_KEY);
            Program.books = new MyMySql(database: "smartlib_books", dbpass, username: dbuser);
            Program.other = new MyMySql(database: "smartlib_other", dbpass, username: dbuser);
            Program.users = new MyMySql(database: "smartlib_users", dbpass, username: dbuser);
        }

        private void LoginDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLogedIn)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SettingsDialog().ShowDialog(this);
        }
    }
}
