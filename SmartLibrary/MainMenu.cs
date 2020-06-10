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
    public partial class MainMenu : Form
    {
        string userid = "";
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Login_interface_Load(object sender, EventArgs e)
        {
            Hide();
            new LoginDialog().ShowDialog();
            Show();
        }

        private void btnLend_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

        }

        private void btnPreorder_Click(object sender, EventArgs e)
        {

        }

        private void btnToEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
