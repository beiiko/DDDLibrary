using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Infra.Mappings
{
    public class ClienteMap : EntityTypeConfiguration<Cliente>
    {
        public ClienteMap()
        {
            ToTable("Cliente");
            HasKey(x => x.Id);
            Property(d => d.Cpf.Cpf).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(d => d.Email.MailAdress).HasMaxLength(90);
            Property(d => d.Name.FirstName).HasMaxLength(50);
            Property(d => d.Name.LastName).HasMaxLength(50);
        }
    }
}
