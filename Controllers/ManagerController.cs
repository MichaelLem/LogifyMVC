using Microsoft.AspNetCore.Mvc;

namespace LogifyMVC.Controllers
{
    public class ManagerController : Controller
    {
        [HttpPost]
        public IActionResult Portal(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                return RedirectToAction(nameof(Dashboard));
            }

            ViewBag.Error = "Invalid username or password.";
            return View();
        }

        public IActionResult Portal()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult EmployeeList()
        {
            return View();
        }
        public IActionResult ViewLogs()
        {
            return View();
        }
    }
}
