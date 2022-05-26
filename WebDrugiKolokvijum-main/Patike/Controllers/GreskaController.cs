using Patike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Patike.Controllers
{
    public class GreskaController : Controller
    {
        // GET: Greska
        public ActionResult Index()
        {
            List<Patika> patike = (List<Patika>)HttpContext.Application["patike"];
            if (patike.Count.Equals(0))
            {
                return RedirectToAction("Index", "Unos");
            }
            return View();
        }
    }
}