using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Text;

namespace Infra.Database
{
    internal sealed class Migrations : DbMigrationsConfiguration<DatabaseConnection>
    {
        public Migrations()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseConnection context)
        {

        }
    }
}
