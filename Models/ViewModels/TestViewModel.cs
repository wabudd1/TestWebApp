using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TestWebApp.Data;

namespace TestWebApp.Models.ViewModels
{
    public class TestViewModel
    {
        public List<User> ListOfUsers { get; set; }

        [Display(Name = "New User Name")]
        public string NewUserName { get; set; }
    }
}