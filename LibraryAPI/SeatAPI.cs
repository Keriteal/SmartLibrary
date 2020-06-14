using MyMysql;
using System.Data;

namespace LibraryAPI
{
    public class SeatAPI
    {
        public struct SeatInfo
        {
            public SeatInfo(string roomid, string deskid, string seatid)
            {
                this.roomid = roomid;
                this.deskid = deskid;
                this.seatid = seatid;
            }
            public readonly string roomid;
            public readonly string deskid;
            public readonly string seatid;
        }
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
            string sqlstr = $"INSERT INTO seats (roomid, userid, deskid, seatid, orderdatetime) VALUES ({roomid},{userid}, {deskid},{seatid}, NOW())";
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
    roomid = {roomid}
    AND deskid = {deskid}
    AND seatid = {seatid}";
            return sql.executeNonQuery(sqlstr) == 1;
        }
        #endregion
        public static SeatInfo GetSeatByUser(MyMySql sql_seats, string userid)
        {
            string sqlstr = $@"
SELECT roomid, deskid, seatid
FROM seats
WHERE userid = {userid} AND backdatetime IS NULL";
            DataRow row = sql_seats.executeQueryFirst(sqlstr);
            if (row != null)
            {
                return new SeatInfo(row["roomid"].ToString(), row["deskid"].ToString(), row["seatid"].ToString());
            }
            else
            {
                return new SeatInfo(null, null, null);
            }
        }
    }
}
