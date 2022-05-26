using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            User user = (User)Session["user"];
            if (user == null)
                return RedirectToAction("Index", "Authentication");
            Dictionary<Product, int> cart = (Dictionary<Product, int>)Session["cart"];
            ViewBag.User = (User)Session["user"];
            return View(cart);
        }

        public ActionResult SortByCount()
        {
            User user = (User)Session["user"];
            if (user == null)
                return RedirectToAction("Index", "Authentication");
            Dictionary<Product, int> cart = (Dictionary<Product, int>)Session["cart"];
            var ret = from entry in cart orderby entry.Value ascending select entry;

            Dictionary<Product, int> sorted = new Dictionary<Product, int>();
            foreach (var item in ret)
            {
                sorted.Add(item.Key, item.Value);
            }
            ViewBag.User = (User)Session["user"];
            return View("Index",sorted);
        }

        public ActionResult SortByPrice()
        {
            User user = (User)Session["user"];
            if (user == null)
                return RedirectToAction("Index", "Authentication");
            Dictionary<Product, int> cart = (Dictionary<Product, int>)Session["cart"];
            var ret = from entry in cart orderby entry.Key.Price ascending select entry;

            Dictionary<Product, int> sorted = new Dictionary<Product, int>();
            foreach (var item in ret)
            {
                sorted.Add(item.Key, item.Value);
            }
            ViewBag.User = (User)Session["user"];
            return View("Index", sorted);
        }
    }
}