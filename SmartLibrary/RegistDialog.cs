using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAPI;

namespace SmartLibrary
{
    public partial class RegistDialog : Form
    {
        public RegistDialog()
        {
            InitializeComponent();
        }

        private void Form2_regiser_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (UserPass.Text.Equals(UserRepeat.Text))
            {
                string SQLstr = "INSERT INTO users(`username`, `password`) " +
                    $"VALUES ('{UserName.Text.Trim()}','{EncryptionUtils.getMD5(UserPass.Text.Trim())}')";
                int result = Program.users.executeNonQuery(SQLstr);
                if (result == 1)
                {
                    MessageBox.Show("注册成功");
                    Close();
                }
                else
                {
                    MessageBox.Show("注册失败");
                }
            }
            else
            {
                MessageBox.Show("前后密码不一致");
            }
        }
    }
}
