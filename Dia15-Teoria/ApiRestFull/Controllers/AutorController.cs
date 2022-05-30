using ApiRestFull.Context;
using ApiRestFull.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiRestFull.UOfWork;

namespace ApiRestFull.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutorController : ControllerBase
    {
        /*public readonly ApplicationDBContext context;
        public AutorController(ApplicationDBContext context)
        {
            this.context = context;
        }*/
        private readonly IUnitOfWork context;
        public AutorController(IUnitOfWork context)
        {
            this.context = context;
        }


        [HttpGet]
        public ActionResult<IEnumerable<Autor>> Get()   //Get   /api/autor
        {
            //return context.Autor.Include(x => x.Libros).ToList();
            try
            {
                var aux = context.autores.GetAutoresYLibros();
                return Ok(aux);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Autor> FindID(int id)
        {
            try
            {
                //var autor = context.Autor.FirstOrDefault(x => x.Id == id);   //Devuelve al autor solamente (sin libros)
                //var autor = context.Autor.Where(x => x.Id == id).Include(x => x.Libros).FirstOrDefault();   //Devuelve los libros del autor tambien
                var autor = context.autores.GetAutorXLibro(id);
                if (autor == null)
                {
                    return NotFound();
                }
                return autor;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }        
        [HttpPost]
        public ActionResult Post([FromBody] Autor autor)
        {
            try
            {
                context.autores.Insert(autor);
                context.Save();
                /*context.Autor.Add(autor);
                context.SaveChanges();*/
                return new CreatedAtRouteResult("Autor", new { id = autor.Id }, autor);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Autor autor, int id)
        {
            try
            {
                if (id != autor.Id)
                {
                    return BadRequest();
                }
                context.autores.Update(autor);
                context.Save();
                /*context.Entry(autor).State = EntityState.Modified;
                context.SaveChanges();*/
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("{numero}")]
        public ActionResult<Autor> Delete(int numero)        
        {
            try
            {
                //var autor = context.Autor.FirstOrDefault(x => x.Id == numero);
                var autor = context.autores.GetById(numero);
                if (autor == null)
                {
                    return NotFound();
                }
                //context.Autor.Remove(autor);
                /*context.Entry(autor).State = EntityState.Deleted;
                context.SaveChanges();*/
                context.autores.Delete(numero);
                context.Save();

                return autor;
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
