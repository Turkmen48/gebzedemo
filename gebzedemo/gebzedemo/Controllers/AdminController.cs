using gebzedemo.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace gebzedemo.Controllers
{

    public class AdminController : Controller
    {
        ///authentication



        public IActionResult Login()
        {


            return View();


        }

        [HttpPost]
        public async Task<IActionResult> Login(AdminCred adminCredits)
        {

            if (adminCredits.Username == "admin" && adminCredits.Password == "admin")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, adminCredits.Username)
                };
                var userIdentity = new ClaimsIdentity(claims, "Admin");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Admin");


            }
            else
            {
                TempData["msg"] = "Kullanici Adi veya Sifre Yanlis";
            }
            return View();


        }

        [Authorize]
        public IActionResult Index()
        {



            return View();
        }















    }
}
