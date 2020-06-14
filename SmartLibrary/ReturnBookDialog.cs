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
    public partial class ReturnBookDialog : Form
    {
        public ReturnBookDialog()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReturnBookDialog_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("还书", "确认是否还书", MessageBoxButtons.YesNo) == DialogResult.Yes)
                if (listView1.SelectedItems.Count == 1)
                {
                    string logid = listView1.SelectedItems[0].SubItems[3].Text;
                    BookAPI.ReturnBook(Program.users, logid);
                    LoadData();
                }
        }
        private void LoadData()
        {
            DataTable dt = Program.users.executeQuery($@"
SELECT
	books.bookid bookid,
	books.bookname bookname,
	borrowlog.borrowdatetime borrowdatetime,
    borrowlog.logid login
FROM
	users,
	borrowlog,
	smartlib_books.books 
WHERE
	users.userid = borrowlog.userid
	AND borrowlog.bookid = books.bookid 
	AND borrowlog.returndatetime IS NULL
    AND users.userid = {Program.userinfo.userid}");
            if (dt == null)
            {
                return;
            }
            else
            {
                listView1.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    var item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        string str = row[i].ToString();
                        Console.WriteLine(":" + str);
                        item.SubItems.Add(row[i].ToString());
                    }
                    listView1.Items.Add(item);
                }
            }
        }
    }
}
