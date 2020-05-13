using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApp.Data
{
    public class DataRepository
    {
        public static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static List<User> GetAllUsers()
        {
            using (MockDb db = new MockDb())
            {
                return db.Users;
            }
        }

        public static List<User> AddUser(User newUser)
        {
            using (MockDb db = new MockDb())
            {
                db.Users.Add(newUser);

                return db.Users.ToList();
            }
        }

    }
}