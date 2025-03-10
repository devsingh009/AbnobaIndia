using AbnobaIndia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbnobaIndia.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult test()
        {
            return View();
        }
        public ActionResult AdminLogin()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult AdminLogin()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult UserLogin(string userid, string password)
        //{

        //}
        // }
        public JsonResult AdminLogins(AbnobaIndia.Models.AdminLoginMaster objbAdminLogin)
        {
            int result = 0;
            List<AdminLoginMaster> LoginResult = new List<AdminLoginMaster>();
            using (abnobaEntities objDBContext = new abnobaEntities())
            {
                var Result = objDBContext.spAdminLogin(objbAdminLogin.UserId, objbAdminLogin.Password).FirstOrDefault();
                if (Result != null)
                {
                    

                    LoginResult.Add(new AdminLoginMaster()
                    {
                        UserId = Result.UserId,
                        FirstName = Result.FirstName,
                        LastName = Result.LastName,
                        MobileNo = Result.MobileNo,
                        Role = Result.Role,
                        Password = Result.Password,
                        Loginstatus = Convert.ToInt32(Result.ResultValue)
                    });


                }
            }
            var log = LoginResult.FirstOrDefault();

            if (log.Loginstatus == 1)
            {
                result = log.Loginstatus;
                System.Web.HttpContext.Current.Session["UserId"] = log.UserId;
                System.Web.HttpContext.Current.Session["FirstName"] = log.FirstName;
                System.Web.HttpContext.Current.Session["Role"] = log.Role;
                System.Web.HttpContext.Current.Session["MobileNo"] = log.MobileNo;
               // return RedirectToAction("Index", "Admin", new { area = "Admin" });
            }
            else
            {
                result = log.Loginstatus;
                //return RedirectToAction("AdminLogin", "Login");

            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }


    }
}