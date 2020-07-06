using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookWeb.Models;
using Microsoft.AspNetCore.Authorization;
using BookWeb.Interface;
using Microsoft.AspNetCore.Identity;
using BookWeb.Entities;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using BookWeb.Interfaces;
using BookWeb.Enums;
using BookWeb.Dtos;

namespace BookWeb.Controllers
{
    public class AccountController : BaseController
    {

        private readonly IAccount _account;

        private readonly SignInManager<ApplicationUser> _signInManager;
        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly RoleManager<ApplicationRole> _roleManager;
        //string Message = "";

        //public AccountController(SignInManager<ApplicationUser> signInManager,
        //    RoleManager<ApplicationRole> roleManager,
        //    UserManager<ApplicationUser> userManager)
        //{
        //    _signInManager = signInManager;
        //    _userManager = userManager;
        //    _roleManager = roleManager;
        //}


        public AccountController(IAccount account, SignInManager<ApplicationUser> signInManager)
        {
            _account = account;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "UserName/Password is incorrect");
                return View();
            }

            var signin = await _account.LoginIn(login);

            if (signin)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }


        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(ApplicationUser user, SignUpViewModel model)
        {
            var sign = await _account.CreateUser(user, model.Password);

            if (sign)
            {
                Alert("Account created successfully", NotificationType.success);
                return RedirectToAction("Login", "Account");
            }
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> LogOut()
        {

            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");


        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        ////TO CREATE A NEW USER(SIGN-UP PAGE)
        //public async Task<IActionResult> Signup(UserDtos registerUser)
        //{
        //    ApplicationUser Appuser = new ApplicationUser();

        //    Appuser.FirstName = registerUser.FirstName;
        //    Appuser.LastName = registerUser.LastName;
        //    Appuser.UserName = registerUser.Username;
        //    Appuser.Email = registerUser.Email;
        //    Appuser.PhoneNumber = registerUser.PhoneNo;
            
        //    var newUser = await _account.CreateUser(Appuser, registerUser.Password);
        //    if (newUser)
        //        return RedirectToAction("Index");

        //    return View();


        //}
    }
}
