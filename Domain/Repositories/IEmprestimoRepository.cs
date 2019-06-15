using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IEmprestimoRepository
    {
        void Save(Emprestimo emprestimo);

        Task<List<Emprestimo>> GetEmprestimo();

        Emprestimo GetEmprestimoById(Guid servicoId);

        Emprestimo GetEmprestimoByLivro(Guid id);

        Emprestimo GetEmprestimoByCliente(Guid id);
    }
}
