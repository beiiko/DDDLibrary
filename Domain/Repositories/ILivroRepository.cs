using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ILivroRepository
    {
        Livro GetById(Guid Id);

        void Save(Livro livro);

        Task<List<Livro>> GetLivro();
    }
}
