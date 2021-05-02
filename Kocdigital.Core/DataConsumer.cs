using Kocdigital.Core.Model;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocdigital.Core
{
    public class DataConsumer : IConsumer<IDataWrapperModel>
    {
        public async Task Consume(ConsumeContext<IDataWrapperModel> context)
        {
            Console.WriteLine(context.Message.Id);
        }
    }
}
