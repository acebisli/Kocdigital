using System;
namespace Kocdigital.Core.Model.Configuration
{
    public class GenericAppSetting
    {
        public RabbitMqOptions RabbitMQ { get; set; }
        public ProducerSettings Producer { get; set; }
        public ElasticSettings Elastic { get; set; }
        public string ApiUrl { get; set; }
    }
}
