using projektmvc.Models;
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
			List<ProductModel> products = (List<ProductModel>)Session["Products"];
			List<OrderItem> orderedItems = new List<OrderItem>();

			return View();
        }

        public ActionResult AddToCart(string productId, string productName, string productPrice)
        {
            List<ProductModel> products = (List<ProductModel>)Session["Products"];
            List<OrderItem> orderedItems = new List<OrderItem>();

            int id = int.Parse(productId);
            int price = int.Parse(productPrice);
            bool inCart = false;
            int NumInStock = 0;

            //Kolla om varan finns i lager
            foreach (ProductModel m in products)
            {
                if (m.Id == id)
                {
                    NumInStock = (m.NumberInStock > 0) ? m.NumberInStock : 0;
                  
                }
            }

            //Kolla om id:t redan finns i ordern
            foreach (OrderItem item in orderedItems)
            {
                if (item.Id == id)
                {
                    inCart = true;
                    break;
                }
            }

            if (!inCart)
            {
                orderedItems.Add(new OrderItem(id, productName, price, 1));
                Session["Cart"] = orderedItems;
            }


            //OrderItem itemToBuy = new OrderItem(id, productName, price, 1);

            //Kolla mot Session["Cart"], den får inte vara null
            Session["Cart"] = orderedItems;

            
            if (Session["Cart"] != null)
            {


            }


            return View("ShoppingCart");  //"Products", products

        }
    }
}

