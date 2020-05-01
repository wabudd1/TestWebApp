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

        
        public User AddUser(User user)
        {
            return DataRepository.AddUser(user);
        }

        
        public Fibonnacci GetFibonacci()
        {
            return DataRepository.GetFibonacci(50);
        }
    }
}