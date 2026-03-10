using Microsoft.AspNetCore.Mvc;

namespace LogifyMVC.Controllers
{
    public class CompanyController : Controller
    {
        [HttpPost]
        public IActionResult Portal(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                return RedirectToAction("Portal", "Manager");
                // or RedirectToAction("Dashboard", "Manager");
            }

            ViewBag.Error = "Invalid login.";
            return View();
        }
        public IActionResult Portal()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
