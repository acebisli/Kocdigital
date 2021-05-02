using Kocdigital.Core.Model;
using Kocdigital.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kocdigital.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataStoreController : ControllerBase
    {
        private IDataWrapperService _dataService;

        public DataStoreController(IDataWrapperService dataService)
        {
            _dataService = dataService;
        }
       // POST api/<DataWrapperController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DataWrapperModel value)
        {
            var response = await _dataService.SaveAsync(value);
            return Ok(response.Result == Nest.Result.Created);
        }
    }
}
