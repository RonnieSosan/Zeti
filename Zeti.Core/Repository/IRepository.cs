using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zeti.Core.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(string id);
        IQueryable<TEntity> GetAll();
    }
}
