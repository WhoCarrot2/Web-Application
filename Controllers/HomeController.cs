using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Application.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Show that new code will be executed as soon as the source has changed
            var version = "version-2.0.0";

            return View(model:version);
        }
    }
}
