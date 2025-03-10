using AbnobaIndia.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbnobaIndia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contacts()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [ActionName("expert-circles")]
        public ActionResult expertcircles()
        {
            ViewBag.Message = "Your Expert page.";

            return View();
        }

        [HttpPost]
        public JsonResult SubmitEnquiry(string name = "", string emailId = "")
        {
            int result = 1;
            result = 1;
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [ActionName("privacy-policy")]
        public ActionResult privacypolicy()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public JsonResult SignUp(UsersLogin objUserLogin)
        {
            int RESULT = 0;
            using (abnobaEntities objDbContext = new abnobaEntities()) {
                ObjectParameter objParam= new ObjectParameter("RESULT", typeof(int));
                objUserLogin.WantToReceiveDocEmail = true;
                var result = objDbContext.spUserRegistrationItems(objUserLogin.FirstName, objUserLogin.LastName, objUserLogin.EmailId, objUserLogin.Password,
                    objUserLogin.Zip, objUserLogin.Country, objUserLogin.Profession, objUserLogin.Discipline, objUserLogin.FieldOfActivity, objUserLogin.WantToReceiveDocEmail, objParam);
                if (objParam.Value != null)
                {
                    RESULT = Convert.ToInt32(objParam.Value);
                }
            }
                return Json(RESULT, JsonRequestBehavior.AllowGet);
        }


 
        public JsonResult UserLogin(UsersLogin objUserLogin)
        {
            int result = 0;
            using (abnobaEntities objDbContext = new abnobaEntities())
            {
                ObjectParameter objParam = new ObjectParameter("result", typeof(int));

                var res = objDbContext.spUsersLogin(objUserLogin.UserName, objUserLogin.Password, objParam);
                if (objParam.Value != null)
                {
                    result = Convert.ToInt32(objParam.Value);
                }
                if (result == 1)
                {
                    System.Web.HttpContext.Current.Session["LoginUser"] = res;

                }
            }
                return Json(result,JsonRequestBehavior.AllowGet);
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Information()
        {
            if (Session["LoginUser"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("expert-circles", "Home");
            }
        }
    }
}