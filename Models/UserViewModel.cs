using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApp.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DateModified { get; set; }
        public bool? IsActive { get; set; }
    }
}