using DemoProject.Models;
using DemoProject.Services.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }
        public string Login(User user)
        {
            SecurityService securityService = new SecurityService();
            Boolean checkLogin = securityService.Authenticate(user);
            if (checkLogin)
            {
                return "Success login!";
            }
            else
            {
                return "Failure. Not logged in";
            }
        }
        //string userName;
        //string password;
        //public string Register(User user)
        //{
            
        //    if(user.Username == userName && user.Password == password)
        //    {
        //        return "Register success.";
        //    }
        //    else
        //    {
        //        return "Register fail.";
        //    }
        //}
        public ActionResult Profile(User user)
        {
            if(user.Username != null && user.Password != null)
            {
                return View(user);
            }
            return RedirectToAction("Login");
        }
    }
}