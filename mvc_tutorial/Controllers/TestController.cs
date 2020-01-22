using mvc_tutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_tutorial.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            //ViewBag.Name = "jemila";
            List<Employe> employeList = new List<Employe>();
            Employe employe = new Employe();


            employeList.Add(new Employe { EmployeID = 1, Name = "jemil", Department = "itsc" });
            employeList.Add(new Employe { EmployeID = 2, Name = "kemil", Department = "itsc" });
            employeList.Add(new Employe { EmployeID = 3, Name = "lemil", Department = "itsc" });
            employeList.Add(new Employe { EmployeID = 4, Name = "gemil", Department = "itsc" });

            return View(employeList);
        }
    }
}