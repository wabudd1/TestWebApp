using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApp.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateModified { get; set; }
        public bool IsActive { get; set; }

        private static int nextId = 1001;

        public User() {

            Id = nextId;
            nextId++;
            DateModified = DateTime.Now;
            IsActive = true;
        }

    }
}