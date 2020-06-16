using LibraryAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
            if (Util.Read("dbuser").Equals("") || Util.Read("dbpass").Equals(""))
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
            SeatAPI.SeatInfo seatinfo= SeatAPI.GetSeatByUser(Program.other, Program.userinfo.userid);
            // 预约座位
            if (seatinfo.roomid == null)
            {
                new SeatsDialog().Show(this);
            }
            else
            {
                if(MessageBox.Show("是否退订？","已存在预定的记录", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if(SeatAPI.Leave(Program.other, seatinfo.roomid, seatinfo.deskid, seatinfo.seatid))
                    {
                        MessageBox.Show("退订成功");
                        new SeatsDialog().Show(this);
                    }
                    else
                    {
                        MessageBox.Show("退订失败");
                    }
                }
            }
        }

        public void onGetUserInfo(UserAPI.UserInfo userinfo)
        {
            Console.WriteLine(userinfo.type);
            if (userinfo.type == UserAPI.USER_TYPE.ADMIN)
            {
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                tabControl1.SelectedIndex = 0;
                LoadLectures();
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

        private void button2_Click(object sender, EventArgs e)
        {
            new SettingsDialog().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LectureManager().ShowDialog(this);
        }

        private void BookManage_Click(object sender, EventArgs e)
        {
            new BookManager().ShowDialog(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            new LoginDialog().ShowDialog(this);
            Show();
        }

        private void LoadLectures()
        {
            DataTable dt = LectureAPI.GetLectuer(Program.other);
            flowLayoutPanel1.SuspendLayout();
            foreach(DataRow row in dt.Rows)
            {
                LectureInfo item = new LectureInfo(row["lecturename"].ToString(), row["lecturedescription"].ToString(), row["releasedatetime"].ToString(), row["outdatedatetime"].ToString());
                flowLayoutPanel1.Controls.Add(item);
            }
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.AutoScroll = true;
        }

        private void UserManage_Click(object sender, EventArgs e)
        {
            new UserManager().ShowDialog(this);
        }
    }
}
