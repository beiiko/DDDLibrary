using Shared.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public class CPF : ValueObject
    {
        public CPF(string cpf)
        {
            Cpf = cpf;

            if (string.IsNullOrWhiteSpace(cpf))
                throw new Exception("Cpf digitado incorretamente");

            if (cpf.Length < 11 || cpf.Length > 11)
                throw new Exception("Cpf tem que ter exsatamente 11 digitos");
        }
        public string Cpf { get; set; }
    }
}
