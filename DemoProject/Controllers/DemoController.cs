using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoProject.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [OutputCache(Duration =10)]
        public string Index()
        {
            return DateTime.Now.ToString("T");
        }
    }
}