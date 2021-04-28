using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kocdigital.Core.Model
{
    public class DataWrapperModel
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("operationName")]
        public string OperationName { get; set; }

        [JsonPropertyName("clienName")]
        public string ClienName { get; set; }

        [JsonPropertyName("createdTime")]
        public DateTime CreatedTime { get; set; }

        [JsonPropertyName("data")]
        public List<DataModel> Data { get; set; }
    }
}
