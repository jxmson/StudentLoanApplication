using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentLoan.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentLoan.Controllers
{ 
    [Authorize]
    public class AccountController : Controller
    {
        // GET: /<controller>/
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private string role = "Applicant";

        public AccountController(SignInManager<IdentityUser> _signInManager, UserManager<IdentityUser> _userManager, RoleManager<IdentityRole> _roleManager)
        {
            signInManager = _signInManager;
            userManager = _userManager;
            roleManager = _roleManager;
        }
    
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginModel
            { 
                ReturnUrl = returnUrl }
                );
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel loginmodel)
        {
            if(ModelState.IsValid)
            {
                IdentityUser user = await userManager.FindByEmailAsync(loginmodel.Email);
                if(user != null)
                {
                    var result = await signInManager.PasswordSignInAsync(user, loginmodel.Password, false, false);
                    if(result.Succeeded)
                    {
                        return Redirect(loginmodel?.ReturnUrl ?? "/Home/Index");
                    }
                }
            }
            ModelState.AddModelError("", "Invalid email or password");
            return View(loginmodel);
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View(); 
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {
            if(ModelState.IsValid)
            {
                if(await roleManager.FindByNameAsync(role) == null)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
                var user = new IdentityUser
                {
                    UserName = registerModel.UserName,
                    Email = registerModel.Email
                };

                var result = await userManager.CreateAsync(user, registerModel.Password);
                if(result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, role);
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    foreach  (var error in result.Errors.Select(x => x.Description))
                    {
                        ModelState.AddModelError("", "Unable to register new user");
                    }
                }
            }
            return View(registerModel);
        }
        
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
        //public IActionResult Profile()
        //{
        //    retrun View();
        //}
    }
}
