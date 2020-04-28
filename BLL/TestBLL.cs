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
        public void AddUser()
        {
            throw new NotImplementedException();
        }

        // TODO:  Implement me.  Add return type and parameter(s) if needed.
        public void GetFibonacci()
        {
            throw new NotImplementedException();
        }
    }
}