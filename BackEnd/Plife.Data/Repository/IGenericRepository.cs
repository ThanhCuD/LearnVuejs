using System;
using System.Collections.Generic;
using System.Text;

namespace Plife.Data.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        void Insert(T entity);
        void Save();
        IEnumerable<T> GetAll();
    }
}
