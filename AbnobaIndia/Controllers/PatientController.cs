using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbnobaIndia.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("mistletoe-therapy")]
        public ActionResult mistletoetherapy()
        {
            return View();
        }

        [ActionName("mistletoe-therapy-patient-information")]
        public ActionResult mistletoetherapypatientinformation()
        {
            return View();
        }

        public ActionResult faq()
        {
            return View();
        }

    }
}