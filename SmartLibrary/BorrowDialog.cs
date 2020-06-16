using LibraryAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SmartLibrary
{
    public partial class BorrowDialog : Form
    {
        
        public BorrowDialog()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("提交", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            List<string> bookids = new List<string>();
            // 提交
            foreach (ListViewItem listViewItem in listView1.Items)
            {
                Console.WriteLine(":"+listViewItem.Text);
                bookids.Add(listViewItem.Text);
            }
            BookAPI.BorrowBooks(Program.users, Program.userinfo.userid, bookids);
        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in listView1.SelectedItems)
            {
                listView2.Items.Add((ListViewItem)listViewItem.Clone());
                listView1.Items.Remove(listViewItem);
            }
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem listViewItem in listView2.SelectedItems)
            {
                listView1.Items.Add((ListViewItem)listViewItem.Clone());
                listView2.Items.Remove(listViewItem);
            }
        }

        private void BorrowDialog_Load(object sender, EventArgs e)
        {
            DataTable dt = Program.books.executeQuery(@"
SELECT
	books.bookid,
	books.bookname,
    books.bookauthor,
	books.bookcount - COUNT( smartlib_users.borrowlog.bookid ) bookremain
FROM
	books
	LEFT JOIN smartlib_users.borrowlog ON books.bookid = smartlib_users.borrowlog.bookid 
	AND smartlib_users.borrowlog.returndatetime IS NULL 
GROUP BY
	books.bookid 
ORDER BY
	bookid;");
            if(dt == null)
            {
                return;
            }
            else
            {
                listView2.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    var item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        string str = row[i].ToString();
                        item.SubItems.Add(row[i].ToString());
                    }
                    listView2.Items.Add(item);
                }
            }
        }
    }
}
