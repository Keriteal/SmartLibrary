using MyMysql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
