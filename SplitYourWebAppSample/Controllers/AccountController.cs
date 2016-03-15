using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using SplitYourWebAppSample.Models;

namespace SplitYourWebAppSample.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {

        public AccountController()
        {
        }


        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var claimsIdentity = new ClaimsIdentity("ApplicationCookie");
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, model.Email));
            Request.GetOwinContext().Authentication.SignIn(claimsIdentity);

            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var claimsIdentity = new ClaimsIdentity("ApplicationCookie");
                claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, model.Email));
                Request.GetOwinContext().Authentication.SignIn(claimsIdentity);

                return RedirectToAction("Index", "Home");
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult LogOff()
        {
            Request.GetOwinContext().Authentication.SignOut("ApplicationCookie");
            return RedirectToAction("Index", "Home");
        }
    }
}