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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RegistDialog f_regiser = new RegistDialog();
            f_regiser.Show(this);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("登陆成功");
            MainMenu login = new MainMenu();
            login.Show(this);
        }
    }
}
