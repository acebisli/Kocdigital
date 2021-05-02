using Kocdigital.Core;
using Kocdigital.Core.Model;
using Kocdigital.Core.Model.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kocdigital.WebApi
{
    public static class Extensions
    {

        public static void AddElasticsearch(this IServiceCollection services, IConfiguration configuration)
        {
            var config = AppSettingsHelper.GetConfig<GenericAppSetting>();


            var settings = new ConnectionSettings(new Uri(config.Elastic.ConnectionUrl))
                .DefaultIndex("defaultindex")
                .DefaultMappingFor<DataWrapperModel>(m => m
                .IndexName(config.Elastic.IndexName)
            );
            settings.BasicAuthentication("elastic", "changeme");

            var client = new ElasticClient(settings);

            services.AddSingleton<IElasticClient>(client);


            client.Indices.Create(config.Elastic.IndexName,
                index => index.Map<DataWrapperModel>(x => x.AutoMap())
            );
        }
    }
}
