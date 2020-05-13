using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLog;
using TestWebApp.Data;

namespace TestWebApp.BLL
{
    public class TestBLL
    {
        public static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public List<User> GetUsers()
        {
            return DataRepository.GetAllUsers();
        }

        // TODO:  Implement me.  Add return type and parameter(s) if needed.
        public List<User> AddUser(string userName)
        {
            var newUser = new User()
            {
                Id = 12345,
                Name = userName,
                DateModified = DateTime.Now,
                IsActive = true
            };

            return DataRepository.AddUser(newUser);
        }

        public User AddUserButJquery(string username)
        {
            // would normally add to db but am lazy rn

            return new User()
            {
                Id = 1234567,
                Name = username,
                DateModified = DateTime.Now,
                IsActive = true
            };
        }
    }
}