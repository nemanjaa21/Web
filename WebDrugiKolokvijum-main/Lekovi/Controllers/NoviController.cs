using Lekovi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lekovi.Controllers
{
    public class NoviController : Controller
    {
        // GET: Novi
        public ActionResult Index()
        {
            List<Lek> lekovi = (List<Lek>)HttpContext.Application["lekovi"];

            return View(lekovi);
        }
    }
}