using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using System.Web.UI;
using TestWebApp.Data;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View(DataRepository.GetAllUsers());
        }

        public ActionResult Fib()
        {
            return View(DataRepository.GetFibonacci(50));
        }

        [HttpPost]
        public string Index(string username)
        {
            var user = new User
            {
                Name = username
            };
            user = DataRepository.AddUser(user);
            // Need to fix this so I'm not rendering HTML in backend.
            var userRow =
                "<tr><td>" + user.Name +
                "</td><td>" + user.DateModified +
                "</td><td>" + user.IsActive +
                "<td></tr>";
            return (userRow);
        }
    }
}