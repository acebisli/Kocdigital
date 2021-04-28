using System;
using System.Text.Json.Serialization;

namespace Kocdigital.Core.Model
{
    public class DataModel
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("minValue")]
        public string MinValue { get; set; }

        [JsonPropertyName("maxValue")]
        public string MaxValue { get; set; }

        [JsonPropertyName("actualValue")]
        public double ActualValue { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
