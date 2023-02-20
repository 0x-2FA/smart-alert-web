using Microsoft.AspNetCore.Mvc;
using RestSharp;
using smart_alert_web.Models.Response;

namespace smart_alert_web.Controllers
{
    public class AlertsController : Controller
    {
        public IActionResult Index()
        {
            var client = new RestClient("http://localhost:12021");
            var request = new RestRequest("/events/important", Method.Get);
            var response = client.Get<ImportantEventResponse>(request);
            return View(response);
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
