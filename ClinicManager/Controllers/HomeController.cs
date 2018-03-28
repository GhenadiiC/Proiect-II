using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicManager.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pacient()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Doctor()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}