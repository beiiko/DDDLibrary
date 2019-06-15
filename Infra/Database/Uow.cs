using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Database
{
    public class Uow : IUow
    {
        private readonly DatabaseConnection db;

        public Uow(DatabaseConnection context)
        {
            db = context;
        }
        public void Commit()
        {
            db.SaveChanges();
        }

        public void Rollback()
        {

        }
    }
}
