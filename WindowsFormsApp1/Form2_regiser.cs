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
    public partial class Form2_regiser : Form
    {
        public Form2_regiser()
        {
            InitializeComponent();
        }

        private void Form2_regiser_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("注册成功");
            this.Close();
        }
    }
}
