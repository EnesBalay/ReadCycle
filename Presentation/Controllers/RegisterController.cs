﻿using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class RegisterController : Controller
    {
        UserManager userManager = new UserManager(new EfUserRepository());
        [AllowAnonymous]
        public IActionResult RegisterAjax(User newUser)
        {
            UserValidator uv = new UserValidator();
            ValidationResult results = uv.Validate(newUser);
            if (results.IsValid)
            {
                User user = new User();
                user.Name = newUser.Name;
                user.EmailAddress = newUser.EmailAddress;
                user.PhoneNumber = newUser.PhoneNumber;
                user.Password = newUser.Password;
                user.AccountType = "User";
                userManager.Add(user);
                return Json(new { success = "true" });
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return Json(new { success = "false" });
        }

    }
}
