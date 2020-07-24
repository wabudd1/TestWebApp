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

        public static User AddUser(string name, int id)
        {
            return new User()
            {
                Id = id,
                Name= name,
                DateModified = DateTime.Now,
                IsActive = true,
            };
        }

    }
}