using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplyGitDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        /// <summary>
        /// test Github  
        /// </summary>
        /// <returns></returns>
        public ActionResult Index2()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        //
    }
}
