using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
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
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index(List<ValidationFailure> errors)
        {
            ViewBag.LoginErrorUser = "";
            ViewBag.RegisterSuccess = "";
            ViewBag.RegisterFailed = "";
            if (errors.Count != 0)
            {
                foreach (var item in errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    System.Console.WriteLine(item.ToString());
                }
            }
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
                if (datavalue.Password == p.Password)
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
                }
            }
            else
            {
                if (p.Name != null || p.Password != null)
                {
                    UserValidator uv = new UserValidator();
                    ValidationResult results = uv.Validate(p);
                    if (results.IsValid)
                    {
                        User user = new User();
                        user.Name = p.Name;
                        user.EmailAddress = p.EmailAddress;
                        user.PhoneNumber = p.PhoneNumber;
                        user.Password = p.Password;
                        user.AccountType = "User";
                        userManager.Add(user);
                        ViewBag.RegisterSuccess = "Kayıt Başarılı";
                    }
                    else
                    {
                        foreach (var item in results.Errors)
                        {
                            ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                        }
                        ViewBag.RegisterFailed = "Kayıt Gerçekleşmedi!";
                    }
                }
                else
                {

                    ViewBag.LoginErrorUser = "Kullanıcı adı ya da şifre hatalı!";
                    ViewBag.AccountType = "User";
                    ViewBag.EmailAddress = p.EmailAddress;
                }

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
