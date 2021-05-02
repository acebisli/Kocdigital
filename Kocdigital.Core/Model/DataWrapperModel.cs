using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Kocdigital.Core.Model
{
    public class DataWrapperModel: IDataWrapperModel
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

    public interface IDataWrapperModel
    {
        string Id { get; set; }
        string OperationName { get; set; }
        string ClienName { get; set; }
        DateTime CreatedTime { get; set; }
        List<DataModel> Data { get; set; }
    }
}
