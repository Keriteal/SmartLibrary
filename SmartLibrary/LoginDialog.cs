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
    public partial class LoginDialog : Form
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("登陆成功");
            Close();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            Hide();
            new RegistDialog().ShowDialog();
            Show();
        }
    }
}
