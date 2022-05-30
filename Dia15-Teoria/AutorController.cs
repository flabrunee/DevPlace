using Microsoft.AspNetCore.Mvc;

namespace ApiRestFull.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AutorController : ControllerBase
	{
		public readonly ApplicationDBContext context;

		public AutorController(ApplicattionDBContext context)
		{
			this.context = context;
		}

        [HttpGet]
		public ActionResult<IEnumerable<Autor>> Get()
        {
			return context.Autor.Include(x => x.Libros).ToList();
        }
        [HttpPost]
		public ActionResult Post([FromBody] Autor autor)
        {
			context.Autor.Add(autor);
			context.SaveChanges();
			return new Combiner("Autor", new { id = autor.Id }, autor);
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
		public ActionResult
	}
}