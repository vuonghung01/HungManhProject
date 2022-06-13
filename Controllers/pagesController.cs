using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HungManhProject.Controllers
{
    public class PagesController : Controller
    {
        // GET: pages
        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult ReturnPolicy()
        {
            return View();
        }
    }
}