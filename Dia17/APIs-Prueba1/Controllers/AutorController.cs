﻿using ApiRestFull.Context;
using ApiRestFull.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiRestFull.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutorController : ControllerBase
    {
        public readonly ApplicationDBContext context;
        public AutorController(ApplicationDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Autor>> Get()   //Get   /api/autor
        {
            return context.Autor.Include(x => x.Libros).ToList();
        }
        [HttpPost]
        public ActionResult Post([FromBody] Autor autor)
        {
            context.Autor.Add(autor);
            context.SaveChanges();
            return new CreatedAtRouteResult("Autor", new { id = autor.Id }, autor);
        }
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Autor autor, int id)
        {
            if (id != autor.Id)
            {
                return BadRequest();
            }
            context.Entry(autor).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();

        }
        [HttpDelete("{numero}")]
        public ActionResult<Autor> Delete(int numero)        
        {
            var autor = context.Autor.FirstOrDefault(x => x.Id == numero);
            if (autor == null)
            {
                return NotFound();
            }
            //context.Autor.Remove(autor);
            context.Entry(autor).State = EntityState.Deleted;
            context.SaveChanges();

            return autor;

        }

        [HttpGet("{id}")]
        public ActionResult<Autor> FindID(int id)
        {
            var autor = context.Autor.FirstOrDefault(x => x.Id == id);
            if (autor == null)
            {
                return NotFound();
            }
            return autor;
        }

    }
}