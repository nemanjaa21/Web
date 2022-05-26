using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Product> products = (List<Product>)HttpContext.Application["products"];
            User user = (User)Session["user"];
            if (user == null)
            {
                return RedirectToAction("Index", "Authentication");
            }
            ViewBag.User = user;
            return View(products);
        }

        [HttpPost]
        public ActionResult Add(string name, int count)
        {
            Dictionary<Product, int> cart = (Dictionary<Product, int>)Session["cart"];
            List<Product> products = (List<Product>)HttpContext.Application["products"];
            Product product = products.Find(p => p.Name.Equals(name));
            if (cart.ContainsKey(product))
            {
                cart[product] += count;
            }
            else
            {
                cart.Add(product, count);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}