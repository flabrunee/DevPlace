using ApiRestFull.Entities;
using ApiRestFull.Context;
using Microsoft.EntityFrameworkCore;

namespace ApiRestFull.Repositories.Implements
{
    public class AutorRepo : GenericRepository<Autor>, IAutorRepo
    {
        public AutorRepo(ApplicationDBContext db) : base(db)
        {

        }

        public IEnumerable<Autor> GetAutoresYLibros()
        {
            var aux = _db.Autor.Include(x => x.Libros).ToList();
            return aux;
        }
        //context.Autor.Where(x => x.Id == id).Include(x => x.Libros).FirstOrDefault();   //Devuelve los libros del autor tambien
        public Autor GetAutorXLibro(int id)
        {
            //var aux = _db.Autor.Include(x => x.Libros).ToList();
            return _db.Autor.Where(x => x.Id == id).Include(x => x.Libros).FirstOrDefault();
        }
    }
}
