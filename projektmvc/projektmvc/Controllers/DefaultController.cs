using projektmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projektmvc.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            string username = Request["username"];
            string password = Request["password"];
            string logoutButton = Request["logoutButton"];


            if (username != null)
            {
                //Försök logga in
                List<UserModel> defaultUsers = UserModel.DefaultUsers();

                foreach (UserModel u in defaultUsers)
                {
                    if (username == u.Name)
                    {
                        if (password == u.Password)
                        {
                            Session["LoginStatus"] = true;
                            Session["username"] = username;
                            //return Redirect("/Secure/Index");
                        }
                        break; //Hoppa ur loopen om användarnamn är rätt men inte lösenord
                    }
                }

            }
            else if (logoutButton != null)
            {
                //logga ut
                Session["LoginStatus"] = false;
                Session["username"] = null;
            }
            else
            {
                //business as usual
            }


            return View();
        }
    }
}