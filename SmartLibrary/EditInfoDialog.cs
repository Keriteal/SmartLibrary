using LibraryAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartLibrary
{
    public partial class EditInfoDialog : Form
    {
        string oldUserName = "";
        string oldPass = "";
        public EditInfoDialog()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (UserAPI.Confirm(oldUserName, UserOldPasswd.Text, Program.users).type != UserAPI.USER_TYPE.INVAILD)
            {
                if (!UserNewPasswd.Text.Equals(UserRepeatPasswd.Text)){
                    MessageBox.Show("密码不一致");
                    return;
                }
                if (UserAPI.changeUserInfo(Program.users, Program.userinfo.userid, UserContact.Text, getSex(), UserName.Text, UserNewPasswd.Text))
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("密码错误");
            }
        }

        private void EditInfoDialog_Load(object sender, EventArgs e)
        {
            UserAPI.UserDescription description = UserAPI.GetUserDescription(Program.users, Program.userinfo.userid);
            UserName.Text = description.username;
            oldUserName = description.username;
            oldPass = description.passwd;
            UserContact.Text = description.contact;
            (Controls["radioSex" + description.sex] as RadioButton).Checked = true;
        }

        private int getSex()
        {
            if (radioSex0.Checked)
            {
                return 0;
            }
            return 1;
        }
    }
}
