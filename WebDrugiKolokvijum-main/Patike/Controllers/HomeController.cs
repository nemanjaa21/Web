using Patike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Patike.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Patika> patike = (List<Patika>)HttpContext.Application["patike"];
            if (patike.Count.Equals(0))
            {
                return RedirectToAction("Index","Unos");
            }
            return View(patike);
        }

        [HttpPost]
        public ActionResult Filter(BrendPatika brend)
        {
            List<Patika> patike = (List<Patika>)HttpContext.Application["patike"];

            patike = patike.Where(patika => patika.Brend.Equals(brend)).ToList<Patika>();
            return View("Index",patike);
        
        }
    }
}