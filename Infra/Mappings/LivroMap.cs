using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Infra.Mappings
{
    public class LivroMap : EntityTypeConfiguration<Livro>
    {
        public LivroMap()
        {
            ToTable("Livro");
            HasKey(x => x.Id);
            Property(d => d.Qntidade);
            Property(d => d.Editora).HasMaxLength(50);
            Property(d => d.Autor).HasMaxLength(50);
            Property(d => d.Titulo).HasMaxLength(50);
        }
    }
}
