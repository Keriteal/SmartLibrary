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
    public partial class UserManager : Form
    {
        public UserManager()
        {
            InitializeComponent();
        }

        private void UserManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int privillege = (int)dataGridView1.SelectedRows[0].Cells[2].Value;
            Console.WriteLine(privillege);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string privillege = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                comboBox1.SelectedIndex = int.Parse(privillege);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadData()
        {
            DataTable dt = UserAPI.GetAllUsers(Program.users);
            bindingSource1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string userid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if(UserAPI.ChangePrivillege(Program.users, userid, "" + comboBox1.SelectedIndex))
                {
                    MessageBox.Show("提交成功");
                }
                else
                {
                    MessageBox.Show("提交失败");
                }
            }
            LoadData();
        }
    }
}
