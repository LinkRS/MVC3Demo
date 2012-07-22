using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC3Demo.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/ParameterPass

        public ActionResult ParameterPass(string name)
        {
            ViewBag.Message = "Hello " + name;
            return View(); 
        }

    }
}
