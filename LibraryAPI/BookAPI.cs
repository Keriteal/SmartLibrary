using MyMysql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    class BookAPI
    {
        #region 借书
        static public int BorrowBooks(MyMySql sql, string userid, string[] bookids)
        {
            int result = 0;
            string booklist = "";
            foreach (var bookid in bookids)
            {
                booklist += $"\n({userid}, {bookid}, NOW() )";
            }
            string SQLstr = "INSERT INTO borrowlog(`userid`, `bookid`, `borrowdatetime`) VALUES" +
                booklist;
            result = sql.executeNonQuery(SQLstr);
            return result;
        }
        #endregion
    }
}
