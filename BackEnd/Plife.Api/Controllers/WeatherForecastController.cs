﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Plife.Data.Models;
using Plife.Data.Services;

namespace Plife.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private IWeatherForecastService _service;
        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            IWeatherForecastService service)
        {
            _logger = logger;
            this._service = service;
        }
        
        [HttpGet]
        public object GetData()
        {
            var data = _service.GetAll();
            return data;
        }
    }
}
