using Microsoft.AspNetCore.Mvc;

namespace smart_alert_web.Controllers
{
    public class AlertsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewAlert()
        {
            return View();
        }
        public IActionResult SendAlert()
        {
            return View();
        }
    }
}
