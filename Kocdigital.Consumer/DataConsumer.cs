using Kocdigital.Core;
using Kocdigital.Core.Model;
using Kocdigital.Core.Model.Configuration;
using MassTransit;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Text;
using System.Threading.Tasks;

namespace Kocdigital.Consumer
{
    public class DataConsumer : IConsumer<IDataWrapperModel>
    {
        public async Task Consume(ConsumeContext<IDataWrapperModel> context)
        {
            IDataWrapperModel model = context.Message;
            Console.WriteLine(model.Id);
            var config = AppSettingsHelper.GetConfig<GenericAppSetting>();

            using WebClient client = new WebClient();
            client.Headers["Content-Type"] = "application/json";
            client.UploadStringCompleted += Client_UploadStringCompleted;
            client.UploadDataAsync(new Uri($"{config.ApiUrl}/api/DataStore"), "POST", Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(model)));
        }

        private void Client_UploadStringCompleted(object sender, UploadStringCompletedEventArgs e)
        {
            Console.WriteLine(e.Result);
        }
    }
}
