using System;
using System.Threading.Tasks;
using Kocdigital.Core.Model.Configuration;
using Microsoft.Extensions.Configuration;

namespace Kocdigital.Producer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var builder = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.json", true, true)
                .AddJsonFile($"appsettings.{env}.json", true, true)
                .AddEnvironmentVariables();

            var config = builder.Build();

            var cfg = config.Get<ProducerAppSetting>();

            

            Console.WriteLine("Hello World!");
        }
    }
}
