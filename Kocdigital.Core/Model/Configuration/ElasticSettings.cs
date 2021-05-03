using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kocdigital.Core.Model.Configuration
{
    public class ElasticSettings
    {
        public string ConnectionUrl { get; set; }
        public string IndexName { get; set; }   
        public string Username { get; set; }   
        public string Password { get; set; }   
    }
}
