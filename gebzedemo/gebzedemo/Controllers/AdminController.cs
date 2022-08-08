using Microsoft.AspNetCore.Mvc;

namespace gebzedemo.Controllers
{

    public class AdminController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }


    }
}
