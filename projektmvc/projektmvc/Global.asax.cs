using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using projektmvc.Models;

namespace projektmvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            RegisteredUsersModel regUsers = new RegisteredUsersModel();
            //Test angående produkterna
            List<ProductModel> products = new List<ProductModel>()
            {
                new ProductModel(100, "Ferrari", "Enzo", 0, 1, "http://kedireklam.com/wp-content/uploads/2015/01/2015-Ferrari-Enzo-Concept-Wallpaper.jpg"),
                new ProductModel(200, "Porsche", "911", 10, 2, "http://files2.porsche.com/filestore.aspx/porsche-The-new-image?pool=multimedia&type=galleryimagerwd&id=991-2nd-tu-gallery-exterior-09&lang=none&filetype=preview&version=b871579c-7282-11e5-b52e-0019999cd470"),
                new ProductModel(300, "Lamborghini", "Aventador", 4000000, 1)
            };

            Session["LoginStatus"] = false;
            Session["Users"] = regUsers.GetUsers();
            Session["Products"] = products; //Produkttest
            Session["Cart"] = null;  
        }
    }
}
