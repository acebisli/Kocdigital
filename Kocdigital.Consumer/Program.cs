using Kocdigital.Core;
using Kocdigital.Core.Model.Configuration;
using MassTransit;
using RabbitMQ.Client;
using System;
using System.Threading.Tasks;

namespace Kocdigital.Consumer
{
    class Program
    {
        private static GenericAppSetting config;
        static async Task Main(string[] args)
        {
            config = AppSettingsHelper.GetConfig<GenericAppSetting>();
            var bus = BusConfigurator.ConfigureBus(config,
                s =>
                {
                    s.ReceiveEndpoint(config.RabbitMQ.Queue, endpoint => endpoint.Consumer<DataConsumer>());
                });

            bus.Start();
            Console.WriteLine("Started consuming.");
            Console.ReadLine();

        }



    }
}
