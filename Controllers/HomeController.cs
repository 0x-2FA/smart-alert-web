using Microsoft.AspNetCore.Mvc;
using RestSharp;
using smart_alert_web.Models;
using smart_alert_web.Models.Response;
using System.Diagnostics;

namespace smart_alert_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var client = new RestClient("http://localhost:12021");
            var request = new RestRequest("/events/all", Method.Get);
            var response = client.Get<AllEventsResponse>(request);
            return View(response.listOfEvents);
        }

        [Route("/view")]
        public IActionResult ViewEvent(long id)
        {
            var client = new RestClient("http://localhost:12021");
            var request = new RestRequest("/events/{id}", Method.Get).AddUrlSegment("id",id);
            var response = client.Get<Event>(request);
            return View(response);
        }

        public IActionResult DeleteEvent(long id)
        {
            var client = new RestClient("http://localhost:12021");
            var request = new RestRequest("/events/{id}", Method.Delete).AddUrlSegment("id", id);
            var response = client.Delete<Event>(request);
            return RedirectToAction("Index","Home");
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}