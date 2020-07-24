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

        public User AddUser(string name, int id)
        {
            return DataRepository.AddUser(name, id);
        }

        // TODO:  Implement me.  Add return type and parameter(s) if needed.
        public long[] GetFibonacci()
        {
            var sequence = new long[50];
            sequence[0] = 0;
            sequence[1] = 1;

            for (var i = 2; i < 50; i++)
                sequence[i] = sequence[i - 1] + sequence[i - 2];

            var logString = string.Empty;
            foreach (var num in sequence)
                logString += num + ", ";

            logger.Debug(logString);
            return sequence;
        }
    }
}