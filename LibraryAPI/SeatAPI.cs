using MyMysql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAPI
{
    public class SeatAPI
    {
        #region 获取不可用的座位
        public static DataTable getUnAviliableSeats(MyMySql sql, string roomid)
        {
            string sqlstr = $@"
SELECT
    deskid, seatid
FROM
    seats
WHERE
    roomid = {roomid}
    AND backdatetime IS NULL";
            return sql.executeQuery(sqlstr);
        }
        #endregion
        #region 预订
        public static bool Order(MyMySql sql, string roomid, string deskid, string seatid, string userid)
        {
            string sqlstr = $"INSERT INTO seats (roomid, deskid, seatid, orderdatetime) VALUES ({roomid},{deskid},{seatid}, NOW())";
            return sql.executeNonQuery(sqlstr) == 1; 
        }
        #endregion
        #region 退订
        public static bool Leave(MyMySql sql, string roomid, string deskid, string seatid)
        {
            string sqlstr = $@"
UPDATE 
    seats
SET
    backdatetime = NOW()
WHERE
    roomid = {roomid},
    AND deskid = {deskid}
    AND seatid = {seatid}";
            return sql.executeNonQuery(sqlstr) == 1;
        }
        #endregion
    }
}
