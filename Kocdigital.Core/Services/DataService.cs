using Kocdigital.Core.Model;
using Microsoft.Extensions.Logging;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocdigital.Core.Services
{
    public class DataService : IDataWrapperService
    {
        private readonly IElasticClient _elasticClient;
        private readonly ILogger _logger;

        public DataService(IElasticClient elasticClient, ILogger<DataService> logger)
        {
            _elasticClient = elasticClient;
            _logger = logger;
        }

        public async Task<IndexResponse> SaveAsync(DataWrapperModel model)
        {
            return await _elasticClient.IndexDocumentAsync<DataWrapperModel>(model);
        }

        public async Task<IEnumerable<DataWrapperModel>> Search(SearchModel searchModel)
        {
            var response = _elasticClient.Search<DataWrapperModel>(i => i
            .Query(q => q.MatchAll())
            .SearchDataWrapperModel(searchModel)
          );
            return response.Documents.OfType<DataWrapperModel>().ToList();
        }
    }
}
