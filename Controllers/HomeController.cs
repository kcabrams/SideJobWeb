using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SideJobWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Vivamus consequat diam a ante pretium pellentesque. Donec justo enim, luctus vitae euismod vitae, condimentum non nulla. Nulla in orci mi. Integer massa nisi, euismod ut finibus eu, dictum et felis.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Curabitur at aliquet arcu.";

            return View();
        }
    }
}