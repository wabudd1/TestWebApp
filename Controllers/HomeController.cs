using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using TestWebApp.BLL;
using TestWebApp.Models.ViewModels;
using NLog;
using System.Text;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

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

        public ActionResult NewUser(string newUsername)
        {
            var bll = new TestBLL();
            var users = bll.AddUser(newUsername);
            var viewModel = new TestViewModel()
            {
                ListOfUsers = users,
                NewUserName = newUsername
            };

            return View("Index", viewModel);
        }

        public ActionResult NewUserButJquery(string newUsername)
        {
            var bll = new TestBLL();
            var user = bll.AddUserButJquery(newUsername);

            return Json(user);
        }

        public ActionResult Fib()
        {
            var fibSequence = new MarcoFib(50).fibSequence;

            var sb = new StringBuilder();
            for (int i = 0; i < fibSequence.Count; i++)
            {
                if (i < fibSequence.Count -1)
                {
                    sb.Append(fibSequence[i] + ", ");
                }
                else
                {
                    sb.Append(fibSequence[i]);
                }
            }

            logger.Debug(sb.ToString());
            
            return View(new FibViewModel() { Sequence = fibSequence });
        }
    }
}