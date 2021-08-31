using EidAssignment.BAL;
using EidAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EidAssignment.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account

        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            //var DbUser = db.Users.Where(x => x.Email == user.Email && x.Password == user.Password).FirstOrDefault();
            var DbUser = new AccountsManagementBAL().Login(user);
            if (DbUser != null)
            {
                HttpCookie mycookie = new HttpCookie("UserId");
                mycookie.Value = DbUser.Id.ToString();
                Response.Cookies.Remove("UserId");
                Response.Cookies.Add(mycookie);
                return Redirect("~/Home/Index");
            }
            ViewBag.Error = "Incorrect Details";
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Register(User user)
        {
            //db.Users.Add(user);
            //db.SaveChanges();
            new AccountsManagementBAL().Register(user);
            HttpCookie mycookie = new HttpCookie("UserId");
            mycookie.Value = user.Id.ToString();
            Response.Cookies.Remove("UserId");
            Response.Cookies.Add(mycookie);
            return Redirect("~/Home/Index");


        }
        [HttpGet]
        public ActionResult Logout()
        {
            Response.Cookies.Get("UserId").Expires = DateTime.UtcNow.AddDays(-1);

            return Redirect("~/Home/Index");
        }
    }
}