using MyMysql;
using System.Data;

namespace LibraryAPI
{
    public class LectureAPI
    {
        public static DataTable GetLectuer(MyMySql sql)
        {
            string sqlstr = $@"
SELECT * FROM lecture";
            return sql.executeQuery(sqlstr);
        }
    }
}
