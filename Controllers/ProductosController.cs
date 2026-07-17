using Microsoft.AspNetCore.Mvc;

namespace LaEconomica.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("promociones-del-mes/barrio-norte")]
        public IActionResult OfertasEspeciales()
        {
            ViewData["Message"] = "Ofertas exclusivas para los vecinos del barrio.";
            return View();
        }
    }
}