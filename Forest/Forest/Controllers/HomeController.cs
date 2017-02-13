using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Forest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Categories()
        {
            ViewBag.Message = "Your Categories.";

            return View();
        }

        public ActionResult Recordings()
        {
            ViewBag.Message = "Your Recordings.";

            return View();
        }
    }
}