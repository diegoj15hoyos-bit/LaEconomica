using Microsoft.AspNetCore.Mvc;

namespace LaEconomica.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}