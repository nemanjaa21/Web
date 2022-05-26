using Patike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Patike.Controllers
{
    public class UnosController : Controller
    {
        // GET: Unos
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Unesi(Patika patika, string NaAkciji)
        {
            List<Patika> patike = (List<Patika>)HttpContext.Application["patike"];
            if (NaAkciji == null)
            {
                patika.Akcija = "Ne";
            }
            else
            {
                patika.Akcija = "Da";
            }
            Patika pat = patike.Find(p => p.Id == patika.Id);
            if (pat == null)
            {
                patike.Add(patika);
            }
            else
            {
                return RedirectToAction("Index","Greska");
            }
            return RedirectToAction("Index","Home");
        }
    }
}