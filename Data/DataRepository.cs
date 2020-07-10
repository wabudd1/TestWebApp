using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApp.Data
{
    public class DataRepository
    {
        private static List<User> UserList = new List<User>();

        public static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static List<User> GetAllUsers()
        {
            if (UserList.Count == 0)
            {
                using (MockDb db = new MockDb())
                {
                    UserList.AddRange(db.Users);
                }
            }
            return UserList;
        }

        public static void AddUser(User user)
        {
            int Id = 0;
            foreach (User u in UserList)
            {
                // Find the biggest Id used so far.
                Id = Math.Max(Id, u.Id);
            }
            // Biggest Id used so far plus 1.
            user.Id = Id + 1;
            user.DateModified = DateTime.Now;
            UserList.Add(user);
        }
    }
}