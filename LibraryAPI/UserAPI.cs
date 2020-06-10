namespace LibraryAPI
{
    static public class UserAPI
    {
        public enum USER_TYPE
        {
            READER, ADMIN, FAILED
        }

        static public UserInfo Confirm(string username, string password)
        {

            return new UserInfo("", USER_TYPE.FAILED);
        }
    }
    public class UserInfo
    {
        public string userid;
        UserAPI.USER_TYPE type;
        public UserInfo(string userid, UserAPI.USER_TYPE type)
        {
            this.userid = userid;
            this.type = type;
        }
    }
}
