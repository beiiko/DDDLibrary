using Domain.Enum;
using Domain.ValueObjects;
using Shared.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Livro : Entity
    {


        public Livro(string title, string autor, string publisher, decimal quantity)
        {
            Titulo = title;
            Autor = autor;
            Editora = publisher;
            Qntidade = quantity;

        }

        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public string Editora { get; private set; }
        public decimal Qntidade { get; private set; }

        public override string ToString()
        {
            return Titulo;
        }

        public void DecreaseQuantity(decimal quantity)
        {
            Qntidade -= quantity;
        }
    }
}
