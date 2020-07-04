using System;
using System.Collections.Generic;
using System.Text;

namespace Plife.Data.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
