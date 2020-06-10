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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            RegistDialog f_Regiser = new RegistDialog();
            f_Regiser.Show(this);
        }

        private void Login_interface_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BorrowDialog s = new BorrowDialog();
            s.Show(this);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            EditInfoDialog f2 = new EditInfoDialog();
            f2.Show(this);
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            ReturnBookDialog b = new ReturnBookDialog();
            b.Show(this);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SeatsDialog S = new SeatsDialog();
            S.Show(this);
        }
    }
}
