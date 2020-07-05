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
            this.repository = new GenericRepository<WeatherForecast>();
        }

        public List<WeatherForecast> GetAll()
        {
            var data = repository.GetAll().ToList();
            return data;
        }
    }
}
