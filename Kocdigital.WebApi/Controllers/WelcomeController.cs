using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kocdigital.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WelcomeController : ControllerBase
    {
     

        private readonly ILogger<WelcomeController> _logger;

        public WelcomeController(ILogger<WelcomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "OK";
        }
    }
}
