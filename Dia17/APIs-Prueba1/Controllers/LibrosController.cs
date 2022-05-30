using ApiRestFull.Context;
using ApiRestFull.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiRestFull.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibrosController : ControllerBase
    {
        public readonly ApplicationDBContext context;
        public LibrosController(ApplicationDBContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult<List<Libros>> Get()
        {
            var libros = context.Libros.Include(x => x.Autor).ToList();
            return libros;
        }

    }
}
