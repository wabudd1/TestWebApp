using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApp.Data
{
    public class MockDb : IDisposable
    {
        public bool IsDisposed { get; set; }
        public List<User> Users { get; set; }

        public MockDb()
        {
            IsDisposed = false;
            var random = new Random(1090293801);

            Users = new List<User>();
            
            for (int i = 0; i < 10; i++)
            {
                Users.Add(new User()
                {
                    Id = random.Next(1, 100) * i,
                    Name = $"User Name {i}",
                    DateModified = DateTime.Now,
                    IsActive = true
                });
            }

        }

        public void AddUser(User user)
        {
            Users.Add(user);

        }

        public void Dispose()
        {
            IsDisposed = true;
        }
    }
}