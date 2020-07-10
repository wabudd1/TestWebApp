using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestWebApp.ViewModels;

namespace TestWebApp.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            List<UserVM> UserVMlist = new List<UserVM>();
            foreach (Data.User item in Data.DataRepository.GetAllUsers())
            {
                UserVM VMItem = new UserVM();
                VMItem.Id = item.Id;
                VMItem.Name = item.Name;
                VMItem.DateModified = item.DateModified;
                VMItem.IsActive = item.IsActive;
                UserVMlist.Add(VMItem);
            }
            return View(UserVMlist);
        }

        public ActionResult Create(UserVM newUser)
        {
            if (!String.IsNullOrEmpty(newUser.Name))
            {
                Data.User user = new Data.User();
                user.Id = newUser.Id;
                user.Name = newUser.Name;
                user.DateModified = newUser.DateModified;
                user.IsActive = newUser.IsActive;
                Data.DataRepository.AddUser(user);
                return RedirectToAction("Index");
            }
            return View(newUser);
        }

        public ActionResult Edit()
        {
            throw new NotImplementedException();
        }

        public ActionResult Details()
        {
            throw new NotImplementedException();
        }

        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}