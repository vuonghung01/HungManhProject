using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HungManhProject.Controllers
{
    public class collectionsController : Controller
    {
        // GET: collections
        public ActionResult all()
        {
            return View();
        }
    }
}