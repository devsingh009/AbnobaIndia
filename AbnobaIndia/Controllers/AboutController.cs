using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbnobaIndia.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("abnoba-gmbh")]
        public ActionResult abnobagmbh()
        {
            return View();
        }

        [ActionName("abnoba-india")]
        public ActionResult abnobaindia()
        {
            return View();
        }

        public ActionResult services()
        {
            return View();
        }

    }
}