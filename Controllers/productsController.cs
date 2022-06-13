using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HungManhProject.Controllers
{
    public class productsController : Controller
    {
        // GET: products
        public ActionResult productsName()
        {
            return View();
        }
    }
}