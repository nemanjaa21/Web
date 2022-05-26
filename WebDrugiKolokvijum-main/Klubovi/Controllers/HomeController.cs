using Klubovi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Klubovi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Klub> klubovi = (List<Klub>)HttpContext.Application["klubovi"];
            if(klubovi.Count == 0)
                return RedirectToAction("Index", "Register");
            return View(klubovi);
        }
    }
}