using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class ModeratorController : Controller
    {
        // GET: Moderator
        public ActionResult Index()
        {
            User user = (User)Session["user"];
            if (user == null)
            {
                return RedirectToAction("Index", "Authentication");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            List<Product> products = (List<Product>)HttpContext.Application["products"];
            if (!products.Contains(product))
            {
                products.Add(product);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}