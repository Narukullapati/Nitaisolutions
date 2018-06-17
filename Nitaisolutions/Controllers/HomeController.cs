using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nitaisolutions.NitaiDB;
using Nitaisolutions.Models;

namespace Nitaisolutions.Controllers
{
    public class HomeController : Controller
    {

        LoginAPI LP = new LoginAPI();

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Dashboard()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Consultation()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        public ActionResult Signin()
        {
            return View();

        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";


            //if (!String.IsNullOrEmpty(userName))
            //{
            //    System.Web.Security.FormsAuthentication.SetAuthCookie(user.Username, false);
            //    return RedirectToAction("Index", "Home");
            //}

            return View("~/Views/Portal/Index.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(Userinfo User)
        {
            return View("~/Views/Home/Signin.cshtml");
        }
    }
}