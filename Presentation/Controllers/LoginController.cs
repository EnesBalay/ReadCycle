﻿using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Turtle.Controllers
{
    public class LoginController : Controller
    {
        UserManager userManager = new UserManager(new EfUserRepository());
        [AllowAnonymous]
        public IActionResult Index()
        {
            var userValues = userManager.GetUserByEmail(User.Identity.Name);
            if (userValues == null)
            {
                return View();

            }
            else if (userValues.AccountType == "Admin")
            {
                return RedirectToAction("Privacy", "Home", new { area = "Admin" });

            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(User p)
        {
            User datavalue = userManager.GetUserByEmail(p.EmailAddress);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, p.EmailAddress)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.LoginErrorUser = "Kullanıcı adı ya da şifre hatalı!";
                ViewBag.AccountType = "User";
                ViewBag.EmailAddress = p.EmailAddress;

            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }

        public IActionResult NoAuthorize()
        {
            return View();
        }
    }
}
