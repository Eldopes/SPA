﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoSPA.Controllers
{
    public class SPAController : Controller
    {
        // GET: SPA
        public ActionResult Index()
        {
            return View();
        }
    }
}