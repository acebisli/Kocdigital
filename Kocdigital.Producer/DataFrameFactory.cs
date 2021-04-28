using Bogus;
using Kocdigital.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocdigital.Producer
{
    public class DataFrameFactory
    {
        public static DataWrapperModel CreateDataWrapper(string clientName)
        {
            var fakerData = new Faker<DataModel>();
            fakerData.RuleFor(s => s.Id, Guid.NewGuid().ToString())
                .RuleFor(s => s.MinValue, f => f.Random.Double(0, 100).ToString())
                .RuleFor(s => s.MaxValue, (f, u) => f.Random.Double(Convert.ToDouble(u.MinValue), 100).ToString())
                .RuleFor(s => s.ActualValue, f => f.Random.Double(0, 100))
                .RuleFor(s => s.Status, (f, u) =>
                {
                    return Convert.ToDouble(u.MaxValue) > u.ActualValue && u.ActualValue > Convert.ToDouble(u.MinValue) ? "OK" : "NOK";
                });

            var faker = new Faker<DataWrapperModel>();
            faker.RuleFor(s => s.Id, Guid.NewGuid().ToString())
                .RuleFor(s => s.ClienName, clientName)
                .RuleFor(s => s.CreatedTime, DateTime.Now)
                .RuleFor(s => s.OperationName, "Getting Data From PLC")
                .RuleFor(s => s.Data, f => fakerData.Generate(2));

            return faker.Generate();
        }
    }
}
