using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWebApp.Data;
using Microsoft.Ajax.Utilities;
using System.Configuration;
using NLog.Layouts;
using NLog;
using TestWebApp.Utilities;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()


        {
            return View();

        }


     
        public ActionResult Fibonacci()
        {
            MyLogger.GetInstance().Debug("method firiing");

            {
                int a = 0;
                int b = 1;

                for (int i = 0; i < 51; i++)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                    Response.Write("<p>fibonacci sequence " + b.ToString() + "</p>");
                }

                MyLogger.GetInstance().Debug("fibonacci sequence " + b.ToString());

                return View();
            }
        }
        public ActionResult ViewAll()
        {

            return View(GetAllUsers());
        }

        IEnumerable<User> GetAllUsers()
        {
            using (MockDb db = new MockDb())
            {
                return db.Users.ToList<User>();
            }
        }

        public ActionResult AddUser(int id =0)
        {
            User user = new User();
            return View(user);
        }

        [HttpPost]
        public ActionResult AddUser(User user)
        {
            using (MockDb db = new MockDb())
            {
                db.Users.Add(user);
               //db.SaveChanges();
            }
            return RedirectToAction("ViewAll");
        }


        

    }
    
}