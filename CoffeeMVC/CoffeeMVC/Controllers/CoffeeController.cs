using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeMVC.Controllers
{
    public class CoffeeController : Controller
    {
        // GET: Coffee
        public ActionResult Index()
        {
            return View();
        }
        // About
        public ActionResult About()
        {
            return View();
        }
        // Coffee
        public ActionResult Coffee()
        {
            return View();
        }
    }
}