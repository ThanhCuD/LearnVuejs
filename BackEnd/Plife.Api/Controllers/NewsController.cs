using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Plife.Data.Models;
using Plife.Data.ParamModel;
using Plife.Data.Services;

namespace Plife.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NewsController : ControllerBase
    {
        private readonly ILogger<NewsController> _logger;
        private INewsService _service;
        public NewsController(ILogger<NewsController> logger,
            INewsService service)
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
        [HttpPost("Save")]
        public IActionResult Save(SaveNewsParamModel param)
        {
            try
            {
                _service.Save(param);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(new { message = "Error: " + ex.Message });
            }
           
        }
    }
}
