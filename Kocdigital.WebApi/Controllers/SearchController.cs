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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private IDataWrapperService _dataService;

        public SearchController(IDataWrapperService dataService)
        {
            _dataService = dataService;
        }
        // POST api/<Search>
        [HttpPost]
        public async Task<IEnumerable<DataWrapperModel>> Search([FromBody] SearchModel model)
        {
            var response = await _dataService.Search(model);
            return response;
        }
    }
}
