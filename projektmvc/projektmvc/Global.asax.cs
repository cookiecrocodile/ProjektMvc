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
            Session["LoginStatus"] = false;
            Session["Users"] = regUsers.GetUsers();
            
            
        }
    }
}
