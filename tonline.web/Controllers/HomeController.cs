using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tonline.web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
	    int a = int.Parse("a1");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public string[] GetList()
        {
            return null;
            //return new string[] { "H","e","l","l","o" };
        }
    }
}