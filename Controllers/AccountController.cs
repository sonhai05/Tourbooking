using Microsoft.AspNetCore.Mvc;

namespace Tourbooking.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string email, string password)
        {
            // TODO: Validate credentials against database
            // For now, just redirect to Tours after login
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Index", "Tours");
            }
            
            ModelState.AddModelError("", "Invalid email or password");
            return View();
        }

        // GET: Account/Logout
        public IActionResult Logout()
        {
            // TODO: Clear session/cookie after implementing auth
            return RedirectToAction("Index", "Home");
        }
    }
}
