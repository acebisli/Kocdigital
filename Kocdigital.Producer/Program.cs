using System;
using System.IO;
using System.Threading.Tasks;
using Kocdigital.Core;
using Kocdigital.Core.Model.Configuration;
using Microsoft.Extensions.Configuration;

namespace Kocdigital.Producer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cfg = AppSettingsHelper.GetConfig<ProducerAppSetting>();
            var producedData = DataFrameFactory.CreateDataWrapper(cfg.Producer.ClientName);

        }
    }
}
