using Microsoft.AspNetCore.Mvc;
using RestSharp;
using smart_alert_web.Models;
using smart_alert_web.Models.Request;
using smart_alert_web.Models.Response;

namespace smart_alert_web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginForm loginForm)
        {
            var client = new RestClient("http://localhost:12021");
            LoginRequest loginRequest = new LoginRequest(loginForm.email, loginForm.password);
            var request = new RestRequest("/auth/login", Method.Post).AddJsonBody(loginRequest);
            var response = client.Post<LoginResponse>(request);
            return RedirectToAction("Index","Home");
        }
    }
}
