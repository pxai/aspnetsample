﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

// Hola
namespace ASPNetSampleApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ' Welcome to Home
            return View();
        }
    }
}
