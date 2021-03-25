using Newtonsoft.Json;
namespace XamarinAPI.Models
{
    public class Host
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }
    }
}
