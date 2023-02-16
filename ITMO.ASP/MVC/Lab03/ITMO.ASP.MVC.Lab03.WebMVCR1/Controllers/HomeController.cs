using ITMO.ASP.MVC.Lab03.WebMVCR1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASP.MVC.Lab03.WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        private static PersonRepository db = new PersonRepository();

        public ViewResult Index()
        {
            ViewBag.Greeting = ModelClass.ModelHello();
            ViewData["Mes"] = "хорошего настроения";
            return View("Index");
        }

        [HttpGet]
        public ViewResult InputData()
        {
            return View("InputData");
        }

        [HttpPost]
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p);
            return View("Hello", p);
        }

        public ViewResult OutputData()
        {
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Count = db.NumberOfPerson;
            return View("ListPerson");
        }

        //public string Index(string hel)
        //{
        //    string Greeting = ModelClass.ModelHello() + ", " + hel;
        //    return Greeting;
        //}
    }
}