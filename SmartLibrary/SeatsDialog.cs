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
    public partial class SeatsDialog : Form
    {
        public SeatsDialog()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string Room = comboBox1.Text;
            string SelectedDesk = "";
            string SelectedSeat = "";
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if ((Controls["groupBox1"].Controls[$"radio{i}_{j}"] as RadioButton).Checked)
                    {
                        SelectedSeat = i.ToString();
                        SelectedDesk = j.ToString();
                        break;
                    }
                }
            }

            if (SeatAPI.Order(Program.seats, Room, SelectedDesk, SelectedSeat, Program.userinfo.userid))
            {
                MessageBox.Show("预约成功");
                Close();
            }
        }

        private void SeatsDialog_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            LoadData();
        }

        private void LoadData()
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    (Controls["groupBox1"].Controls[$"radio{i}_{j}"] as RadioButton).Enabled = true;
                }
            }
            string Room = comboBox1.Text;
            DataTable dt = SeatAPI.getUnAviliableSeats(Program.seats, Room);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string deskid = row["deskid"].ToString();
                    string seatid = row["seatid"].ToString();
                    Console.WriteLine(deskid + "  " + seatid);
                    (Controls["groupBox1"].Controls[$"radio{deskid}_{seatid}"] as RadioButton).Enabled = false;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
