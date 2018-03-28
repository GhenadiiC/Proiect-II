using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClinicManager.Models;

namespace ClinicManager.Controllers
{
    public class PacientsController : Controller
    {
        // GET: Pacients/Random
        public ActionResult Random()
        {
            {
                var pacient = new Pacient() { Id = 1, Name = "John" };

                return View(model: pacient);
            }
        }
    }
}