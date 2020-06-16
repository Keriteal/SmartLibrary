using MyMysql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    public class BookAPI
    {
        #region 借书(userid, bookids)
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
        #region 还书 (logid)
        static public void ReturnBook(MyMySql sql, string logid)
        {
            string SQLstr = $"UPDATE borrowlog SET returndatetime = NOW() WHERE logid = {logid}";
            sql.executeNonQuery(SQLstr);
        }
        #endregion

        public static bool AddTag(MyMySql sql, string bookid, string tagid)
        {
            string sqlstr = $@"
INSERT INTO book_tag(bookid, tagid)
VALUES ({bookid}, {tagid})";
            return sql.executeNonQuery(sqlstr) == 1;
        }
        public static bool RemoveTag(MyMySql sql, string bookid, string tagid)
        {
            string sqlstr = $@"
DELETE FROM book_tag
WHERE bookid = {bookid}  AND tagid = {tagid}";
            return sql.executeNonQuery(sqlstr) != 0;
        }
        public static string[] getBooksByTag(MyMySql sql, string tagid)
        {
            string sqlstr = $@"
SELECT bookid
FROM book_tag
WHERE tagid = {tagid}
GROUP BY bookid";
            DataTable table = null;
            if ((table = sql.executeQuery(sqlstr)) != null)
            {
                string[] result = table.AsEnumerable().Select(d => d.Field<string>("bookid")).ToArray<string>();
                return result;
            }
            return null;
        }
        public static bool AddBook(MyMySql sql, string bookname, string bookauthor, string bookcount)
        {
            string SQLstr = $@"
INSERT INTO books (bookname, bookauthor, bookcount)
VALUES ('{bookname.Trim()}','{bookauthor.Trim()}',{bookcount})";
            return sql.executeNonQuery(SQLstr) == 1;
        }
        public static bool EditBook(MyMySql sql, string bookid, string bookname, string bookauthor, string bookcount) 
        {
            string SQLstr = $@"
UPDATE books 
SET 
    bookname = '{bookname}',
    bookauthor = '{bookauthor}',
    bookcount = {bookcount}
WHERE 
    bookid = {bookid}";
            return sql.executeNonQuery(SQLstr) == 1;
        }
        public static DataTable GetBooks(MyMySql sql)
        {
            string SQLstr = $@"
SELECT * FROM books;";
            return sql.executeQuery(SQLstr);
        }
    }
}
