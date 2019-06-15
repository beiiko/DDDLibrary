using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Infra.Database;
using System.Data.Entity;

namespace Infra.Repositories
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly DatabaseConnection db;

        public EmprestimoRepository(DatabaseConnection context)
        {
            db = context;
        }

        public Emprestimo GetEmprestimoByLivro(Guid id)
        {
            return db.Emprestimos.FirstOrDefault(d => d.Livro.Id == id);
        }

        public Emprestimo GetEmprestimoById(Guid servicoId)
        {
            return db.Emprestimos.Find(servicoId);
        }

        public Emprestimo GetEmprestimoByCliente(Guid id)
        {
            return db.Emprestimos.FirstOrDefault(d => d.Cliente.Id == id);
        }

        public Task<List<Emprestimo>> GetEmprestimo()
        {
            return db.Emprestimos.OrderBy(d => d.Id).ToListAsync();
        }

        public void Save(Emprestimo emprestimo)
        {
            db.Emprestimos.Add(emprestimo);
            db.SaveChanges();
        }
    }
}
