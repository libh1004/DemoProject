using DemoProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows;

namespace DemoProject.Controllers
{
    public class StudentsController : Controller
    {
        private MyDbContext db = new MyDbContext();
        // GET: Students
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Student student)
        {
            Session["Student"] = student;
            return RedirectToAction("Profile");
        }
        public ActionResult Profile()
        {
            if(Session["Student"] != null)
            {
                return View();
            }
            return Redirect("Login");
        }
        public ActionResult Logout(Student student)
        {
            if (Session["Student"] != null)
            {
                Session.Remove("Student");
                TempData["message"] = "Remove session successful";
                return Redirect("Login");
            }
            return Redirect("Profile");
        }
        public ActionResult Index()
        {
            // LINQ query
            // IQueryable<Student> s = from s in db.Students select s;
            //var query = db.Students.Select(s => new
            //{
            //    Name = "Linh"
            //});
            var query2 = db.Students.Where(s => s.Name).Take(2).Skip(1);
            // Take, Skip dùng để phân trang
            return View();
        }
    }
}