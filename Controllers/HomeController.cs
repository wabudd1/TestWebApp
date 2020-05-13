using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWebApp.BLL;
using TestWebApp.Models.ViewModels;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var bll = new TestBLL();
            var users = bll.GetUsers();
            var viewModel = new TestViewModel()
            {
                ListOfUsers = users,
                NewUserName = ""
            };

            return View(viewModel);
        }

        public ActionResult NewUser(string newUserName)
        {
            var bll = new TestBLL();
            var users = bll.AddUser(newUserName);
            var viewModel = new TestViewModel()
            {
                ListOfUsers = users,
                NewUserName = newUserName
            };

            return View("Index", viewModel);
        }
    }
}