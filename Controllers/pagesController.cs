﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HungManhProject.Controllers
{
    public class pagesController : Controller
    {
        // GET: pages
        public ActionResult aboutus()
        {
            return View();
        }
    }
}