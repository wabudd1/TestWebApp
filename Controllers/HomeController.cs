using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWebApp.Controllers
{
    public class HomeController : Controller
    {
               DataRepository dr = new DataRepository();
        MockDb db = new MockDb();


        public ActionResult Index()
        {
            //MockDb db = new MockDb();
            User user = new User();



            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection formCollection)
        {

            using (MockDb db = new MockDb())
            {
                User user = new User();
                //DataRepository dr = new DataRepository();

                user.Name = formCollection["Name"];

                Random rand = new Random();
                int r = rand.Next(0, 100);
                user.Id = r;

                user.DateModified = DateTime.Now;

                user.IsActive = true;

                dr.AddUser(user);
                
                //return this.View(dr);

                return this.RedirectToAction("Display", user);


            }




            

        }

        [HttpGet]
        public ActionResult Display()
        {
            //MockDb db = new MockDb();

            //DataRepository dr = new DataRepository();


            return this.View(dr);
        }

        
        public ActionResult Fibonacci()
        {
            int number = 50 - 1; //Need to decrement by 1 since we are starting from 0  
            
            int[] Fib = new int[number + 1];  
            //int[] Fib = new int[50];  

            Fib[0]= 0;  
            Fib[1]= 1;  
    
            for (int i = 2; i <= number;i++)  
            {  
                Fib[i] = Fib[i - 2] + Fib[i - 1];  
            }
            //return Fib[number]; 

            ViewBag.Fibonacci = Fib;
            //ViewData["Fib"] = Fib;

            return View(ViewBag);
        }
    }
}