using ApiRestFull.Repositories;

namespace ApiRestFull.UOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ILibrosRepo libros { get; }
        IAutorRepo autores { get; }
        void Save();
    }
}