using Microsoft.AspNetCore.Mvc;

namespace LogifyMVC.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpPost]
        public IActionResult Portal(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                return RedirectToAction("TimeTracker", "Logify");
            }

            ViewBag.Error = "Invalid login.";
            return View();
        }
        public IActionResult Portal()
        {
            return View();
        }
    }
}
