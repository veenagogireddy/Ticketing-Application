using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _665Project_ASP.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace _665Project_ASP.Controllers
{
    public class AccountController : Controller
    {
        private readonly Team113DBContext _context;

        public AccountController(Team113DBContext context)
        {
            _context = context;
        }

        public IActionResult Login(string returnURL)
        {
            returnURL = String.IsNullOrEmpty(returnURL) ? "~/Event/Search" : returnURL;
            return View(new LoginInput { ReturnURL = returnURL });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Useremail,UserPassword,ReturnURL")] LoginInput loginInput)
        {
            if (ModelState.IsValid)
            {
                var aUser = await _context.Users.FirstOrDefaultAsync(u => u.EmailId == loginInput.Useremail && u.Password == loginInput.UserPassword);
                if (aUser != null && aUser.UserRoleFk.Equals(2))
                {               
                    var claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Name, aUser.FirstName));
                    claims.Add(new Claim(ClaimTypes.Sid, aUser.UserId.ToString()));
                    claims.Add(new Claim(ClaimTypes.Role, aUser.UserRoleFk.ToString()));
                    string[] roles = aUser.UserRoleFk.ToString().Split(",");

                    foreach (string role in roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                    return Redirect(loginInput?.ReturnURL ?? "~/Events/Search");
                }
                else if (aUser != null && aUser.UserRoleFk.Equals(3))
                {
                    var claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Name, aUser.FirstName));
                    claims.Add(new Claim(ClaimTypes.Sid, aUser.UserId.ToString()));
                    claims.Add(new Claim(ClaimTypes.Role, aUser.UserRoleFk.ToString()));
                    string[] roles = aUser.UserRoleFk.ToString().Split(",");

                    foreach (string role in roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                    return Redirect(loginInput?.ReturnURL ?? "~/");
                }
                else
                {
                    ViewData["message"] = "Invalid credentials";
                }
            }
            return View(loginInput);
        }

        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AdminLogin([Bind("AdminId,Password,ReturnURL")] AdminLoginInput AdminLoginInput)
        {
            if (ModelState.IsValid)
            {
                var aUser = await _context.Admin.FirstOrDefaultAsync(u => u.AdminId == AdminLoginInput.AdminId && u.Password == AdminLoginInput.Password);
                if (aUser != null)
                {
                    var claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.Role, aUser.UserRoleFk.ToString()));
                    string[] roles = aUser.UserRoleFk.ToString().Split(",");

                    foreach (string role in roles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, role));
                    }
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                    return Redirect(AdminLoginInput?.ReturnURL ?? "~/Events/ApproveDenyEvents");
                }
                else
                {
                    ViewData["message"] = "Invalid credentials";
                }
            }
            return View(AdminLoginInput);
        }

        public IActionResult SignUp()
        {
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp([Bind("FirstName,LastName,MobileNumber,EmailId,Password,UserRoleFk")] Users loginInfo)
        {
            if (ModelState.IsValid)
            {
                var aUser = await _context.Users.FirstOrDefaultAsync(u => u.EmailId == loginInfo.EmailId);
                if (aUser is null)
                {
                    _context.Add(loginInfo);
                    await _context.SaveChangesAsync();

                    TempData["success"] = "Account created";

                    return RedirectToAction(nameof(Login));
                }
                else
                {
                    ViewData["message"] = "Choose a different emailid";
                }
            }
            return View(loginInfo);
        }

        public async Task<RedirectToActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Search", "Event");
        }
    }
}