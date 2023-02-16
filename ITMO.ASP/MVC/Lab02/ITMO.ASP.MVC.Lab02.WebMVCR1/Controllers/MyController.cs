using ITMO.ASP.MVC.Lab02.WebMVCR1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASP.MVC.Lab02.WebMVCR1.Controllers
{
    public class MyController : Controller
    {

        public string Index(string hel)
        {
            string Greeting = ModelClass.ModelHello() + ", " + hel;
            return Greeting;
        }
    }
}