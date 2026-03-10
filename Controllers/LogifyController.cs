using Microsoft.AspNetCore.Mvc;

namespace LogifyMVC.Controllers
{
    public class LogifyController : Controller
    {
        public IActionResult TimeTracker()
        {
            return View();
        }
    }
}
