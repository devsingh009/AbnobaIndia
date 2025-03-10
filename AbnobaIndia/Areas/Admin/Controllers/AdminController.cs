using AbnobaIndia.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace AbnobaIndia.Areas.Admin.Controllers
{
    public class AdminController : Controller
    { 
        public int _pageSize = 20, _totalRecord = 0, _totalPage = 0, _currentpage = 0, pageSizeforDisplayItems = 20;


    // GET: Admin/Admin
    public ActionResult Index()
        {
            if (Session["UserId"] != null)
            {

                return View();
            }
            else
            {
                return Redirect("~/Login/AdminLogin");
            }
        }

        public PartialViewResult  GetUserDetails(string Name="", string Profession="", string Discipline="", string FOA="", int Page = 0)
        {
            if (Page == 0)
            {
                Page = 1;
            }
            List<UsersLogin> report = new List<UsersLogin>();
            using (abnobaEntities objDbcontext = new abnobaEntities())
            {
                var data = objDbcontext.spGetUserDetails(Name, Profession,Discipline,FOA).ToList();
                if (data != null)
                {
                    foreach (var obj in data)
                    {
                        report.Add(new UsersLogin()
                        {
                            UserId = obj.UserId,
                            UserName = obj.UserName,
                            FirstName = obj.FirstName,
                            LastName = obj.LastName,
                            Password = obj.Password,
                            Profession = obj.Profession,
                            Discipline = obj.Discipline,
                            FieldOfActivity = obj.FieldOfActivity,
                            LoginAllowed = obj.LoginAllowed,
                            Zip = obj.Zip,
                            Country = obj.Country,
                            CreatedOn = obj.CreatedOn,
                            CreatedBy = obj.CreatedBy,
                            IsActive = obj.IsActive,

                        });
                    }
                }
            }
            var details = report;
            this._totalRecord = details.Count();
            ViewBag.Count = details.Count();
            var pager = new AbnobaIndia.Models.CustomEntities.Pager(this._totalRecord, Page, this._pageSize);
            ViewBag.Pagging = pager;
            if (Page != null && Page > 0)
            {
                this._totalPage = (Page - 1) * this._pageSize;

                var Items = details.OrderBy(x => x.UserId).Skip(this._totalPage).Take(this._pageSize).ToList();
                return PartialView("_ShowUserDetails",Items);
            }
            else
            {
                return PartialView("_ShowUserDetails", details);

            }
        }
        
        public JsonResult ChangeLoginStatus(bool? status, int id, string user, string username, string password)
        {
            string strResult = string.Empty;
            int retVal = 0;
            if (status != null)
            {
                using (abnobaEntities objDbContext = new abnobaEntities())
                {
                    var objLogin = objDbContext.UsersLogins.Where(r => r.UserId == id).FirstOrDefault();

                    objLogin.LoginAllowed = !status.Value;
                    retVal = objDbContext.SaveChanges();
                   
                }

            }
            if (retVal > 0)
                strResult = "UPDATED_SUCCESSFULL";
            if (status == false)
            {


                string EmailId = username;
                string EmailSubject = string.Empty;
                EmailSubject = "Login Credentials";
                string eMailCC = string.Empty;
                ///eMailCC = ConfigurationManager.AppSettings["AdmCCEmail1"].ToString();
                //StringBuilder emailBody = new StringBuilder();

                //emailBody.Append("<b>Hi " + user + "<b><br/><br/>");
                //emailBody.Append("You are authorized for login <br/>");
                //emailBody.Append("Login Details:<br/>");
                //emailBody.Append("Username:   " + username + "<br/>");
                //emailBody.Append("Password:   " + password + "<br/>");
                StringBuilder emailBody = WebUtilities.Utilities.SendMailToCustomer(user, username,password);


                bool ismailSent = WebUtilities.EmailHelper.SendMails(EmailId, eMailCC, emailBody.ToString(), EmailSubject);
            }
             return Json(strResult);

        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Admin");
        }
    }
}