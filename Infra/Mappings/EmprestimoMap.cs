using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Infra.Mappings
{
    public class EmprestimoMap : EntityTypeConfiguration<Emprestimo>
    {
        public EmprestimoMap()
        {
            ToTable("Servico");
            HasKey(d => d.Id);
            HasRequired(d => d.Cliente);
            HasRequired(d => d.Livro);
            Property(d => d.Status);
            Property(d => d.DataEmprestimo);
        }
    }
}
