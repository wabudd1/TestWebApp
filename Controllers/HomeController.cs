using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWebApp.BLL;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        TestBLL TestBLL = new TestBLL();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Table()
        {
            return View(TestBLL.GetUsers());
        }

        public JsonResult CreateUser(string name, int id)
        {
            var newUser = TestBLL.AddUser(name, id);
            return Json(new
                {
                    newUser.Name,
                    newUser.Id,
                    newUser.IsActive,
                    DateModified = newUser.DateModified.ToString(),
             });
        }

        public JsonResult GetFibonacci()
        {
            return Json(TestBLL.GetFibonacci());
        }
    }
}