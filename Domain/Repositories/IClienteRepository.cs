using System;
using Domain.Entities;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IClienteRepository
    {
        Cliente GetById(Guid Id);

        void Save(Cliente cliente);

        Task<List<Cliente>> GetCliente();
    }
}
