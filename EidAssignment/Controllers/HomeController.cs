using EidAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EidAssignment.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            HttpCookie httpCookie = Request.Cookies.Get("UserId");
            if(httpCookie != null)
            {
                var val = httpCookie.Value;
                ViewBag.Id = val;
            }
            return View();
        }

      
    }
}