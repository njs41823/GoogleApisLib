using System.Linq;
using Newtonsoft.Json;

namespace GoogleApisLib.MapsDistanceMatrixApi.Models
{
    public class ApiResponse
    {
        public string RequestString { get; set; }
        public string ResponseJson { get; set; }

        [JsonProperty("destination_addresses")]
        public string[] DestinationAddresses { get; set; }

        [JsonProperty("origin_addresses")]
        public string[] OriginAddresses { get; set; }

        [JsonProperty("rows")]
        public Row[] Rows { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        public Element[] Elements => Rows.SelectMany(r => r.Elements).ToArray();

        public static ApiResponse CreateFromJson(string json) => JsonConvert.DeserializeObject<ApiResponse>(json, Converter.Settings);
    }

    public class Row
    {
        [JsonProperty("elements")]
        public Element[] Elements { get; set; }
    }

    public class Element
    {
        [JsonProperty("distance")]
        public Distance Distance { get; set; }

        [JsonProperty("duration")]
        public Duration Duration { get; set; }

        [JsonProperty("duration_in_traffic")]
        public Duration DurationInTraffic { get; set; }

        [JsonProperty("fare")]
        public Fare Fare { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class Distance
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }
    }

    public class Duration
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }
    }

    public class Fare
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None
        };
    }
}
