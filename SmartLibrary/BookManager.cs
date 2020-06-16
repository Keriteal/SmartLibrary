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
    public partial class BookManager : Form
    {
        public BookManager()
        {
            InitializeComponent();
        }

        private void BookManager_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new BookEditAddDialog().ShowDialog(this);
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                new BookEditAddDialog(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), row.Cells[3].Value.ToString())
                    .ShowDialog(this);
                LoadData();
            }
        }

        private void LoadData()
        {
            DataTable dt = BookAPI.GetBooks(Program.books);
            bindingSource1.DataSource = dt;
        }

        private void BookManager_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
