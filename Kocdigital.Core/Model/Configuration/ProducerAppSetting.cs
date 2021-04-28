using System;
namespace Kocdigital.Core.Model.Configuration
{
    public class ProducerAppSetting
    {
        public RabbitMqOptions RabbitMQ { get; set; }
        public ProducerSettings Producer { get; set; }
    }
}
