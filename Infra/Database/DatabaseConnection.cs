using Domain.Entities;
using Infra.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Infra.Database
{
    public class DatabaseConnection : DbContext
    {
        public DatabaseConnection() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DDD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new LivroMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new EmprestimoMap());
        }
    }
}
