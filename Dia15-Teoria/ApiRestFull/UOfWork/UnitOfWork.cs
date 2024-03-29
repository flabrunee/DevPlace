﻿using ApiRestFull.Repositories;
using ApiRestFull.Context;
using ApiRestFull.Repositories.Implements;

namespace ApiRestFull.UOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _db;
        public ILibrosRepo libros { get; private set; }
        public IAutorRepo autores { get; private set; }

        public UnitOfWork(ApplicationDBContext context)
        {
            _db = context;
            libros = new LibroRepo(context);
            autores = new AutorRepo(context);
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}