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

        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnToRight_Click(object sender, EventArgs e)
        {

        }

        private void BorrowDialog_Load(object sender, EventArgs e)
        {
            DataTable dt = Program.books.executeQuery(@"
SELECT
    books.bookid,
    books.bookname,
    books.bookcount,
    books.bookcount - COUNT(smartlib_users.borrowlog.logid) bookremain
FROM
    books
    LEFT JOIN smartlib_users.borrowlog ON books.bookid = smartlib_users.borrowlog.bookid
    AND smartlib_users.borrowlog.returndatetime IS NOT NULL
    books.bookid
ORDER BY
    bookid; ");
            if(dt == null)
            {
                return;
            }
            else
            {
                listView2.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    var item = new ListViewItem();
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        string str = row[i].ToString();
                        item.SubItems.Add(row[i].ToString());
                    }
                    listView1.Items.Add(item);
                }
            }
        }
    }
}
