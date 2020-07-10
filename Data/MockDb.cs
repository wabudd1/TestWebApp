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

            Users = new List<User>();

            for (int i = 0; i < 10; i++)
            {
                Users.Add(new User()
                {
                    Id = i + 1,
                    Name = $"User Name {i}",
                    DateModified = DateTime.Now,
                    IsActive = true
                });
            }
        }

        public void Dispose()
        {
            IsDisposed = true;
        }
    }
}