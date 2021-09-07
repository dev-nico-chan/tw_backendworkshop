using System.Security.Claims;
using BackendWorkshop.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendWorkshop.Controllers
{
    public class AuthController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        // [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (user == null || !"admin".Equals(user.UserName) || !"admin".Equals(user.PassWord))
            {
                ViewBag.Error = "UserName and PassWord is admin";
                // return View();
                return RedirectToAction("Login");
            }

            if ("admin".Equals(user.UserName) && "admin".Equals(user.PassWord))
            {
                CreateAuthCookie(user.UserName);
                AddValuesToSession(user.UserName);
                ViewBag.UserName = HttpContext.Session.GetString("userName");
                // return View();
                // return RedirectToAction("Page");
                return RedirectToAction("Index", "Movies");
            }

            return View();
        }


        //basic points 14 please make sure this action should be authed.
        [Authorize]
        // [AllowAnonymous]
        public ActionResult Page()
        {
            // # homework 1 -- redirect to movies/index
            // return View();
            // return new RedirectResult("/Movie/Index");
            return View();
        }

        private void CreateAuthCookie(string userName)
        {
            //basic points 16 please add param into Cookie 
            // use cookie auth
            // HttpContext.Response.Cookies.Append("userName", userName,
            //     new CookieOptions {Expires = DateTime.Now.AddMinutes(30)});
            var identity = new ClaimsIdentity(new[] {new Claim(ClaimTypes.Name, userName)},
                CookieAuthenticationDefaults.AuthenticationScheme);
            var principle = new ClaimsPrincipal(identity);
            var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principle);
        }

        private void AddValuesToSession(string userName)
        {
            //basic points 17 Add param into Session and Session key is "userName"
            HttpContext.Session.SetString("userName", userName);
        }
    }
}