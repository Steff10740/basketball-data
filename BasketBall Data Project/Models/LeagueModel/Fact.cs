using Newtonsoft.Json;
namespace XamarinAPI.Models
{
    public class Fact
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
