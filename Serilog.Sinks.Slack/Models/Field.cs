using Newtonsoft.Json;

namespace Serilog.Sinks.SlackExtended.Models
{
    public class Field
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("short")]
        public bool? Short { get; set; }
    }
}