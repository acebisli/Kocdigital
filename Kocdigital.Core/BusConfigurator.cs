using Kocdigital.Core.Model;
using Kocdigital.Core.Model.Configuration;
using MassTransit;
using MassTransit.RabbitMqTransport;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocdigital.Core
{
    public static class BusConfigurator
    {
        public static IBusControl ConfigureBus(GenericAppSetting appSetting,Action<IRabbitMqBusFactoryConfigurator> action)
        {
            return Bus.Factory.CreateUsingRabbitMq(cfg =>
            {
                cfg.Host(new Uri(appSetting.RabbitMQ.Host), hst =>
                {
                    hst.Username(appSetting.RabbitMQ.Username);
                    hst.Password(appSetting.RabbitMQ.Password);
                });
                if (action != null)
                    action(cfg);
            });
        }
    }
}
