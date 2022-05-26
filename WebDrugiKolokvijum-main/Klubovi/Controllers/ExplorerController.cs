using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Klubovi.Controllers
{
    public class ExplorerController : Controller
    {
        // GET: Explorer
        public ActionResult Index()
        {
            return View();
        }
    }
}