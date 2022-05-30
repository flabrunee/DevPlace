using ApiRestFull.Context;
using ApiRestFull.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiRestFull.UOfWork;

namespace ApiRestFull.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LibrosController : ControllerBase
    {
        //public readonly ApplicationDBContext context;
        private  readonly IUnitOfWork context;
        //public LibrosController(ApplicationDBContext context)
        public LibrosController(IUnitOfWork context)
        {
            this.context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Libros>> Get()
        {
            /*var libros = context.Libros.Include(x => x.Autor).ToList();
            return libros;*/
            try
            {
                var libros = context.libros.GetLibrosYAutores();
                return Ok(libros);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("{id}")]
        public ActionResult<Libros> FindID(int id)
        {
            //var autor = context.Autor.FirstOrDefault(x => x.Id == id);
            //var libro = context.Libros.Where(x => x.Id == id).Include(x => x.Autor).FirstOrDefault();

            try
            {
                var libro = context.libros.GetById(id);
                if (libro == null)
                {
                    return NotFound();
                }
                return Ok(libro);
                //return libro;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost]
        public ActionResult Post([FromBody] Libros libro)
        {
            context.libros.Insert(libro);
            context.Save();
            return new CreatedAtRouteResult("Autor", new { id = libro.Id }, libro);
        }
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Libros libro, int id)
        {
            if (id != libro.Id)
            {
                return BadRequest();
            }
            /*context.Entry(libros).State = EntityState.Modified;
            context.SaveChanges();*/
            context.libros.Update(libro);
            context.Save();
            return Ok();
        }
        [HttpDelete("{numero}")]
        public ActionResult<Libros> Delete(int numero)
        {
            var libro = context.libros.GetById(numero);
            if (libro == null)
            {
                return NotFound();
            }
            context.libros.Delete(numero);
            context.Save();
            return Ok(libro);
        }
    }
}
