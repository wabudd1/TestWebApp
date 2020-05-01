using Microsoft.Ajax.Utilities;
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

        // Add user function implemented 4/30 by Marco Costa.
        public static User AddUser(User user)
        {
            // Some mock validation.
            if(user.Name == "")
            {
                user.Name = "Add Name Later";
            }
            
            using (MockDb db = new MockDb())
            {
                var random = new Random(1090293801);
                user.Id = random.Next(1, 100) * db.Users.Count;
                user.DateModified = DateTime.Now;
                user.IsActive = true;
                db.Users.Add(user);
                return user;
            }
        }
        //Fibonnacci function implemented 5/1 by Marco Costa.
        public static Fibonnacci GetFibonacci(int n)
        {
            
            var fib = new Fibonnacci(n);

            // Logging Fibonnacci Sequence
            for (int i = 0; i < fib.fibSequence.Count; i++)
            {
                logger.Info("Fibonnacci #" + (i + 1) + " is: " + fib.fibSequence[i]);
            }
            return fib;
        }

    }
}