using Klubovi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Klubovi.Controllers
{
    public class BodoviController : Controller
    {
        // GET: Bodovi
        public ActionResult Index()
        {
            List<Klub> klubovi = (List<Klub>)HttpContext.Application["klubovi"];
            if (klubovi.Count == 0)
                return RedirectToAction("Index", "Register");
            return RedirectToAction("Index","Home");
        }

        public ActionResult Upis(int id,int bodovi)
        {
            List<Klub> klubovi = (List<Klub>)HttpContext.Application["klubovi"];
            Klub klub = klubovi.Find(k => k.Id == id);
            klub.Bodovi = bodovi;
            return RedirectToAction("Index");
        }
    }
}