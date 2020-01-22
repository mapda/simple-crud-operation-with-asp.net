using mvc_tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_tutorial.Controllers
{
    public class HomeController : Controller
    {
        private Models.demoEntities _db = new demoEntities();
        // GET: Home
        public ActionResult Index()
        {
            var data = (from s in _db.Users select s).ToList();
            ViewBag.users = data;
            ViewBag.title = "Simple Phone Book";

            return View();
        }
    }
}