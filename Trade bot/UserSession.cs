using System;

namespace Trade_bot
{
    public static class UserSession
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public  static bool IsLoggedIn { get; set; }
        public static int? UserID { get; set; }
        public static string[] Roles { get; set; }
    }

}
