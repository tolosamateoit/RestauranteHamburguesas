using Microsoft.AspNetCore.Mvc;
using Restaurante.Models;

namespace Restaurante.Controllers
{
    public class MapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        public IActionResult Mapa()
        {
            var map_direccion = new Map(); // Pasa los datos necesarios al modelo del mapa aquí
            return View("Index", map_direccion);
        }
    }
}
