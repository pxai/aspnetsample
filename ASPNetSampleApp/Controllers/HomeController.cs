using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

// Hola cambio esta
// Otro cambio más
namespace ASPNetSampleApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            'Welcome to Home
            return View();
            //PRobando probando swapon
            //ALlgo algo que tiene que dar un mega conflict
        }
    }
}
