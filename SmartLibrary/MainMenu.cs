using LibraryAPI;
using System;
using System.Windows.Forms;

namespace SmartLibrary
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Login_interface_Load(object sender, EventArgs e)
        {
            if(Util.Read("dbuser").Equals("") || Util.Read("dbpass").Equals(""))
            {
                Hide();
                new SettingsDialog().ShowDialog();
                Show();
            }
            Hide();
            new LoginDialog().ShowDialog(this);
            Show();
        }

        private void btnLend_Click(object sender, EventArgs e)
        {
            // 还书
            new ReturnBookDialog().ShowDialog(this);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            // 借书
            new BorrowDialog().ShowDialog(this);
        }

        private void btnPreorder_Click(object sender, EventArgs e)
        {
            // 预约
            new SeatsDialog().Show(this);
        }

        public void onGetUserInfo(UserAPI.UserInfo userinfo)
        {
            Console.WriteLine(userinfo.type);
            if(userinfo.type == UserAPI.USER_TYPE.ADMIN)
            {
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                tabControl1.SelectedIndex = 0;
            }
        }

        private void btnToEdit_Click(object sender, EventArgs e)
        {
            // 修改信息
            new EditInfoDialog().ShowDialog(this);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Tab | Keys.Control):
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
