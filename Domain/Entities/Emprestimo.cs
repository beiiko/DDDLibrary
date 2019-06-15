using Domain.Enum;
using Shared.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Emprestimo : Entity
    {
        public Emprestimo(Cliente cliente, Livro livro)
        {
            Cliente = cliente;
            Livro = livro;
            DataEmprestimo = DateTime.Now;
            Status = Status.Solicitado;
        }

        public Cliente Cliente { get; private set; }
        public Livro Livro { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public Status Status { get; private set; }
    }
}
