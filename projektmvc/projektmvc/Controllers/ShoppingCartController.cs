using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projektmvc.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult ShoppingCart()
        {
            return View();
        }

        public ActionResult AddToCart()
        {
            //Kolla mot Session["Cart"], den får inte vara null
            return View();
        }
    }
}