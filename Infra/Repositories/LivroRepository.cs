using Domain.Entities;
using Domain.Repositories;
using Infra.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly DatabaseConnection db;

        public LivroRepository(DatabaseConnection context)
        {
            db = context;
        }

        public Livro GetById(Guid Id)
        {
            return db.Livros.Find(Id);
        }

        public Task<List<Livro>> GetLivro()
        {
            return db.Livros.OrderBy(d => d.Id).ToListAsync();
        }

        public void Save(Livro livro)
        {
            db.Livros.Add(livro);
            db.SaveChanges();
        }
    }
}
