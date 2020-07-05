using Microsoft.EntityFrameworkCore;
using Plife.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Plife.Data.Repository
{
    class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private PetLifeContext context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            this.context = new  PetLifeContext();
            this.table = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public void Insert(T entity)
        {
            table.Add(entity);
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
