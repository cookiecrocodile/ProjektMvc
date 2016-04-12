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
                new ProductModel(300, "Lamborghini", "Aventador", 4000000, 1),
                new ProductModel(400, "BMW", "M4", 2000000, 4, "http://images.car.bauercdn.com/pagefiles/20413/01_bmw_m4_gts.jpg"),
                new ProductModel(500, "Ferrari", "488GTB", 300000, 2, "http://roa.h-cdn.co/assets/15/06/1600x800/landscape_nrm_1422971953-150028_car.jpg"),
                new ProductModel(600, "Nissan", "GTR", 100000, 10, "http://img11.deviantart.net/bbac/i/2013/197/d/a/nissan_gt_r_v_spec_by_stedesign_by_steodesign-d6dqa6o.jpg"),
                new ProductModel(700, "Bugatti", "Veyron", 1000000, 1, "http://bestcarmag.com/sites/default/files/6063062bugatti-veyron-05.jpg"),
                new ProductModel(800, "Mclaren", "P1", 800000, 1, "https://i.kinja-img.com/gawker-media/image/upload/s--rl0akGA5--/c_scale,fl_progressive,q_80,w_800/xq6ebpnutamvxlvmi1r9.jpg"),
                new ProductModel(900, "Dragster", "Roadster", 2000, 1, "http://ewallpapershub.net/wp-content/uploads/2015/01/hd-wallpapers-1080p-cars.jpg"),
                new ProductModel(1000, "Ariel Motor", "Atom", 100000, 4, "http://pictures.topspeed.com/IMG/crop/201210/arien-atom-3-5-1_800x0w.jpg"),
                new ProductModel(1100, "Tesla", "Model S", 100000, 15, "http://pictures.topspeed.com/IMG/crop/201210/arien-atom-3-5-1_800x0w.jpg"),
                new ProductModel(1200, "Corvette", "Zr1", 1500000, 3, "http://www.blogcdn.com/www.autoblog.com/media/2012/02/2012-chevrolet-corvette-zr1-review.jpg")
            };

            Session["LoginStatus"] = false;
            Session["Users"] = regUsers.GetUsers();
            Session["Products"] = products; //Produkttest
            Session["Cart"] = null;  
        }
    }
}
