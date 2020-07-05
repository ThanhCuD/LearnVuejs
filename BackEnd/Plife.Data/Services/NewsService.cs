using Plife.Data.Models;
using Plife.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plife.Data.Services
{
    public interface INewsService
    {
        void CreateNewWithRandom();
        List<New> GetAll();
    }
    public class NewsService : INewsService
    {
        private IGenericRepository<New> repository = null;
        public NewsService()
        {
            this.repository = new GenericRepository<New>();
        }

        public void CreateNewWithRandom()
        {
            var result = false;
            var n = new New()
            {
                Title = "test1",
                Description = "des1",
                Body = "body1"
            };
            repository.Insert(n);
            repository.Save();
        }

        public List<New> GetAll()
        {
            var data = repository.GetAll().ToList();
            return data;
        }
    }
}
