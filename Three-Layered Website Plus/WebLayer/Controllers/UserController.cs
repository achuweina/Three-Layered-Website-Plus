using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebSite34.Web.Models.User;

namespace WebSite34.Web.Controllers
{
    public class UserController : Controller
    {

        public ActionResult Login()
        {
            return View(new Login());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Login(Login details)
        {
            if(!ModelState.IsValid) return View(details);
            if (!Membership.ValidateUser(details.Username, details.Password))
            {
                ModelState.AddModelError("Validation","The username and password are invalid to login.");
                return View(details);
            }
            FormsAuthentication.RedirectFromLoginPage(details.Username, details.KeepLoggedIn, FormsAuthentication.FormsCookiePath);
            return View();
        }

        public ActionResult Account()
        {
            return View();
        }

    }
}