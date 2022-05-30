using ApiRestFull.Context;
using ApiRestFull.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiRestFull.Repositories.Implements
{
    public class LibroRepo : GenericRepository<Libros>, ILibrosRepo
    {
        public LibroRepo(ApplicationDBContext db) : base(db)
        {

        }

        public IEnumerable<Libros> GetLibrosYAutores()
        {
            var aux = _db.Libros.Include(x => x.Autor).ToList();
            //Console.WriteLine(aux);
            return aux;
        }
        public Libros GetLibroXAutor(int id)
        {
            var aux = _db.Libros.Where(x => x.Id == id).Include(x => x.Autor).FirstOrDefault();
            return aux;
        }
    }
}