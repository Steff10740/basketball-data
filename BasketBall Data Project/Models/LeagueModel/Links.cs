using Newtonsoft.Json;
namespace BasketBall_Data_Project.Models.LeagueModel
{
    public class Links
    {
        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("prev")]
        public object Prev { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }
    }
}
