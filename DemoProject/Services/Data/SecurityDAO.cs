using DemoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoProject.Services.Data
{
    public class SecurityDAO
    {
        internal bool FindByUser(User user)
        {
            //if(user.Username == "Admin" && user.Password == "admin123")
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            
            // alternative way to write the function.
            return user.Username == "Admin" && user.Password == "admin123";
        }
    }
}