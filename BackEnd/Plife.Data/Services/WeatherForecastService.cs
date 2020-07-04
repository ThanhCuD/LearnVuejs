using Plife.Data.Models;
using Plife.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plife.Data.Services
{
    public interface IWeatherForecastService
    {
        List<WeatherForecast> GetAll();
    }
    public class WeatherForecastService : IWeatherForecastService
    {
        private IGenericRepository<WeatherForecast> repository = null;
        public WeatherForecastService()
        {
            repository = new GenericRepository<WeatherForecast>();
        }
        public WeatherForecastService(IGenericRepository<WeatherForecast> repository)
        {
            this.repository = repository;
        }

        public List<WeatherForecast> GetAll()
        {
            var data = repository.GetAll().ToList();
            return data;
        }
    }
}
