using Google.Apis.SecretManager.v1.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using explorestl.Areas.Identity.Data;
using explorestl.Models;

namespace explorestl.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;

        }

        [HttpGet]
        public IActionResult Profile()
        {
            //Get current userId
            var userId = _userManager.GetUserId(HttpContext.User);
            //If no user is logged in, redirect to Login page
            if (userId == null)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                //Retrieve current logged in users details
                ApplicationUser user = _userManager.FindByIdAsync(userId).Result;
                ViewBag.user = user;
                return View();
            }
        }

    }
}
