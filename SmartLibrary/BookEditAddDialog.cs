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
    public partial class BookEditAddDialog : Form
    {
        readonly bool mode_edit = false;
        string bookname;
        string bookauthor;
        string bookcount;
        string bookid;
        public BookEditAddDialog()
        {
            InitializeComponent();
            mode_edit = false;
            txtBookID.Text = "Auto";
            txtBookID.Enabled = false;
        }

        public BookEditAddDialog(string bookid, string bookname, string bookauthor, string bookcount) : this()
        {
            txtBookName.Text = bookname;
            txtBookID.Text = bookid;
            txtBookAuthor.Text = bookauthor;
            txtBookCount.Text = bookcount;
            mode_edit = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.mode_edit)
            {
                if (BookAPI.EditBook(Program.books, txtBookID.Text, txtBookName.Text, txtBookAuthor.Text, txtBookCount.Text))
                {
                    MessageBox.Show("修改成功");
                    Close();
                    return;
                }
                MessageBox.Show("修改失败");
            }
            else
            {
                if (BookAPI.AddBook(Program.books, txtBookName.Text, txtBookAuthor.Text, txtBookCount.Text))
                {
                    MessageBox.Show("添加成功");
                    Close();
                    return;
                }
                MessageBox.Show("添加失败");
                return;
            }
        }
    }
}
