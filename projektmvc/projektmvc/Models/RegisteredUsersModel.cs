using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projektmvc.Models
{
    public class RegisteredUsersModel
    {
        private List<UserModel> regUsers = new List<UserModel>()
            {
                new UserModel()
                { Name = "karin", Password = "hemligt"},

                new UserModel()
                { Name="tomten", Password="godjul" },

                new UserModel()
                { Name = "admin", Password = "power"},

                new UserModel()
                { Name = "ninja", Password = "katt"},

                new UserModel()
                { Name ="ghost", Password = "ooo" }
            };

        public List<UserModel> GetUsers()
        {
            return regUsers;
        }

        //public bool UserExists(string name)
        //{
        //    foreach (UserModel m in regUsers)
        //    {
        //        if (m.Name == name)
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}
    }
}