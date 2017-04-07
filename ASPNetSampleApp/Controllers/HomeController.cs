using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

// Hola cambio esta
// Otro cambio más
// Y otro más 13:32
namespace ASPNetSampleApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ' Welcome to Home - epa
            return View();
        }
    }
}
