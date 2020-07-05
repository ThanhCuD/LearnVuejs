using Plife.Data.Models;
using Plife.Data.ParamModel;
using Plife.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plife.Data.Services
{
    public interface INewsService
    {
        void Save(SaveNewsParamModel paramModel);
        List<New> GetAll();
    }
    public class NewsService : INewsService
    {
        private IGenericRepository<New> repository = null;
        public NewsService()
        {
            this.repository = new GenericRepository<New>();
        }

        public void Save(SaveNewsParamModel paramModel)
        {
            if(paramModel.ID == Guid.Empty)
            {
                var newModel = new New()
                {
                    Body = paramModel.Body,
                    IsDeleted = false,
                    Title = paramModel.Title,
                    Description = paramModel.Description
                };
                repository.Insert(newModel);
                repository.Save();
            }
        }

        public List<New> GetAll()
        {
            var data = repository.GetAll().ToList();
            return data;
        }
    }
}
