using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Database
{
    public interface IUow
    {
        void Commit();
        void Rollback();
    }
}
