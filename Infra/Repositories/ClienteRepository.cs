using System;
using Domain.Entities;
using Domain.Repositories;
using Infra.Database;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;

namespace Infra.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DatabaseConnection db;

        public ClienteRepository(DatabaseConnection context)
        {
            db = context;
        }

        public Cliente GetById(Guid Id)
        {
            return db.Clientes.Find(Id);
        }

        public Task<List<Cliente>> GetCliente()
        {
            return db.Clientes.OrderBy(d => d.Id).ToListAsync();
        }

        public void Save(Cliente cliente)
        {
            db.Clientes.Add(cliente);
            db.SaveChanges();
        }
    }
}
