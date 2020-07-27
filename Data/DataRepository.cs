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

        static private List<User> Users = new List<User>();


        public static List<User> GetAllUsers()
        {
            using (MockDb db = new MockDb())
            {
                return db.Users;
            }
        }

        // TODO:  Implement me.  Add return type and parameter(s) if needed.
        public static void AddUser(User newUser)
        {
            Users.Add(newUser);
        }

    }
}