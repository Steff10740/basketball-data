using Newtonsoft.Json;
namespace BasketBall_Data_Project.Models.LeagueModel
{
    public class Link
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("label")]
        public object Label { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }
    }
}
