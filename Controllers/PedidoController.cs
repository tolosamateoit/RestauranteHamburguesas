using Microsoft.AspNetCore.Mvc;
using Restaurante.Models;
using Restaurante.Data;
using Microsoft.IdentityModel.Tokens;

namespace Restaurante.Controllers
{


    public class PedidoController : Controller
    {
        private readonly RestauranteContext _context;

        public PedidoController(RestauranteContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult HacerPedido()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HacerPedido(Pedido pedido)
        {

           
            //aqui se pueden hacer validaciones de los campos
            if (ModelState.IsValid)
            {
                _context.Add(pedido);
                await _context.SaveChangesAsync();
                return View("Confirmacion", pedido);
            }
            return View(pedido);
        }

        [HttpGet]
        public IActionResult Confirmacion()
        {
            return View();
        }
    }
}
