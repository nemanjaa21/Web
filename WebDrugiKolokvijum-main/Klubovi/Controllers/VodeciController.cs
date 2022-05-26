using Klubovi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Klubovi.Controllers
{
    public class VodeciController : Controller
    {
        // GET: Vodeci
        public ActionResult Index()
        {
            List<Klub> klubovi = (List<Klub>)HttpContext.Application["klubovi"];
            if(klubovi.Count == 0)
            {
                return RedirectToAction("Index", "Register");
            }
            ViewBag.Klub = (Klub)Session["klub"];
            return View();
        }

        public ActionResult Pronadji()
        {
            List<Klub> klubovi = (List<Klub>)HttpContext.Application["klubovi"];
            int max = klubovi.Max(temp => temp.Bodovi);
            Klub klub = klubovi.Find(temp => temp.Bodovi == max);
            Session["klub"] = klub;
            return RedirectToAction("Index");
        }
    }
}