using System;
namespace Kocdigital.Core.Model.Configuration
{
    public class RabbitMqOptions
    {
        public string Host { get; set; }
        public string Queue { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

    }
}
