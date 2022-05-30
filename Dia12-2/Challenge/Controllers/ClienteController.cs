using Microsoft.AspNetCore.Mvc;
using Challenge.Datos;

namespace Challenge.Controllers
{
    public class ClienteController : Controller
    {
        ClienteDatos clienteDatos= new ClienteDatos();
        public IActionResult Index()
        {
            var lista = clienteDatos.Listar();
            return View(lista);
        }
    }
}
