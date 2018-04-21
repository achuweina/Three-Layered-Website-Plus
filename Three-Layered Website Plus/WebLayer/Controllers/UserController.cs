using System.Web.Mvc;
using System.Web.Security;
using $safeprojectname$.Models.User;
using $safeprojectname$.Properties;

namespace $safeprojectname$.Controllers
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
                ModelState.AddModelError("Validation",Resource.Login_Userdetails_Invalid);
                return View(details);
            }
            FormsAuthentication.RedirectFromLoginPage(details.Username, details.KeepLoggedIn, FormsAuthentication.FormsCookiePath);
            return View();
        }
        
        [Authorize]
        public ActionResult Account()
        {
            return View();
        }

    }
}