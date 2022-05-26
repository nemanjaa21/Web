using Lekovi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lekovi.Controllers
{
    public class GreskaController : Controller
    {
        // GET: Greska
        public ActionResult Index()
        {
            List<Lek> lekovi = (List<Lek>)HttpContext.Application["lekovi"];
            if (lekovi.Count.Equals(0))
                return RedirectToAction("Index","Unos");
            return View();
        }
    }
}