using Domain.Repositories;
using Infra.Database;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.ValueObjects;
using Infra.Repositories;
using System.Threading.Tasks;

namespace Console
{
    public class Program
    {

        static void Main(string[] args)
        {
            DatabaseConnection db = new DatabaseConnection();

            EmprestimoRepository emprestimo = new EmprestimoRepository(db);
            LivroRepository livro = new LivroRepository(db);
            ClienteRepository cliente = new ClienteRepository(db);

            GerarServico(livro, cliente, emprestimo, new Guid(), new Guid());
        }

        public static void GerarServico(ILivroRepository livroRepository, IClienteRepository clienteRepository, IEmprestimoRepository emprestimoRepository, Guid livroId, Guid clienteId)
        {
            try
            {
                var cliente = clienteRepository.GetById(clienteId);
                var livro = livroRepository.GetById(livroId);

                Emprestimo emprestimo = new Emprestimo(cliente, livro);
                emprestimoRepository.Save(emprestimo);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    // Cliente Fake
    public class FakeClienteRepository : IClienteRepository
    {
        public Cliente GetById(Guid id)
        {
            try
            {
                var cliente = new Cliente(new Name("Gustavo", "Cardim"), new Email("gustavo.cardiim@outlook.com"), new CPF("41256378912"));
                return cliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<List<Cliente>> GetCliente()
        {
            throw new NotImplementedException();
        }

        public void Save(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
    // Livro Fake
    public class FakeLivroRepository : ILivroRepository
    {
        public Livro GetById(Guid Id)
        {
            try
            {
                var livro = new Livro("A Sociedade do Anel - Volume 1. Série O Senhor dos Anéis", "J. R. R. Tolkien", "Martins Fontes", 1);
                return livro;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Task<List<Livro>> GetLivro()
        {
            throw new NotImplementedException();
        }

        public void Save(Livro livro)
        {
            throw new NotImplementedException();
        }
    }
}
