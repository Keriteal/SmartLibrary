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
    public partial class login_interface : Form
    {
        public login_interface()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form2_regiser f_Regiser = new Form2_regiser();
            f_Regiser.Show(this);
        }

        private void Login_interface_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.Show(this);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form2_regiser2 f2 = new Form2_regiser2();
            f2.Show(this);
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            Back_Books b = new Back_Books();
            b.Show(this);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form_Seats S = new Form_Seats();
            S.Show(this);
        }
    }
}
