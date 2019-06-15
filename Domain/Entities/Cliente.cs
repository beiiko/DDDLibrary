using Shared.Entity;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Cliente : Entity
    {
        protected Cliente()
        {

        }
        public Cliente(Name name, Email email, CPF cpf)
        {
            Name = name;
            Email = email;
            Cpf = cpf;
        }

        public Name Name { get; private set; }
        public Email Email { get; set; }
        public CPF Cpf { get; set; }
    }
}
