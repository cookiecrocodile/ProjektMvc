using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projektmvc.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public string Password { get; set; }


        //public static List<UserModel> DefaultUsers()
        //{
        //    return new List<UserModel>()
        //    {
        //        new UserModel()
        //        { Name = "karin", Password = "hemligt"},

        //        new UserModel()
        //        { Name="tomten", Password="godjul" },

        //        new UserModel()
        //        { Name = "admin", Password = "power"},

        //        new UserModel()
        //        { Name = "ninja", Password = "katt"},

        //        new UserModel()
        //        { Name ="ghost", Password = "ooo" }
        //    };
        //}



    }
}