using MyMysql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    public class BookAPI
    {
        #region 借书
        static public int BorrowBooks(MyMySql sql, string userid, List<string> bookids)
        {
            int result = 0;
            string booklist = "";
            foreach (var bookid in bookids)
            {
                booklist += $"\n({userid}, {bookid}, NOW()),";
            }
            booklist = booklist.Substring(0, booklist.Length - 1);
            string SQLstr = "INSERT INTO borrowlog(`userid`, `bookid`, `borrowdatetime`) VALUES" + booklist;
            result = sql.executeNonQuery(SQLstr);
            return result;
        }
        #endregion
        static public void ReturnBook(MyMySql sql, string logid)
        {
            string SQLstr = $"UPDATE borrowlog SET returndatetime = NOW() WHERE logid = {logid}";
            sql.executeNonQuery(SQLstr);
        }
    }
}
