using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Kocdigital.Core;
using Kocdigital.Core.Model;
using Kocdigital.Core.Model.Configuration;
using MassTransit;
using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;

namespace Kocdigital.Producer
{
    class Program
    {
        private static IBusControl bus;
        private static GenericAppSetting config;
        static async Task Main(string[] args)
        {
            config = AppSettingsHelper.GetConfig<GenericAppSetting>();
            bus = BusConfigurator.ConfigureBus(config, null);

            System.Timers.Timer aTimer = new System.Timers.Timer(config.Producer.QueueInterval * 1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            Console.ReadLine();

        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            var producedData = DataFrameFactory.CreateDataWrapper(config.Producer.ClientName);
            bus.Publish<DataWrapperModel>(producedData);
            Console.WriteLine("Data Sending");
        }


    }
}
