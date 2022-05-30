using ApiRestFull.Entities;

namespace ApiRestFull.Repositories
{
    public interface IAutorRepo : IGenericRepository<Autor>
    {
        IEnumerable<Autor> GetAutoresYLibros();
        Autor GetAutorXLibro(int id);
    }
}