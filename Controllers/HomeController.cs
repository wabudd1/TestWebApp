using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWebApp.Fibonacci;
using TestWebApp.Models;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        UserDBEntities db = new UserDBEntities();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetUserList()
        {
            List<UserViewModel> UserList = db.tblUser.Where(x => x.IsActive == true).Select(x => new UserViewModel
            {
                Id = x.Id,
                Name = x.Name,
                DateModified = x.DateModified,
                IsActive = x.IsActive,

            }).ToList();
            return Json(UserList, JsonRequestBehavior.AllowGet);


        }

        public JsonResult SaveDataInDatabase(UserViewModel model)
        {
            var result = false;
            try
            {
                if (model.Id > 0)
                {
                    tblUser User = db.tblUser.SingleOrDefault(x => x.IsActive == true && x.Id == model.Id);
                    User.Name = model.Name;
                    User.DateModified = DateTime.Now;
                    db.SaveChanges();
                    result = true;
                }
                else
                {
                    tblUser User = new tblUser();
                    User.Name = model.Name;
                    User.DateModified = DateTime.Now;
                    User.IsActive = true;
                    db.tblUser.Add(User);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult FibonacciSeq(int[] series)
        {
            FibonacciSequence.fibonacci(50);
            
            return View(series);
        }
    }//end class
}//end namespace