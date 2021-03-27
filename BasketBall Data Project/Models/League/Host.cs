using Newtonsoft.Json;
namespace BasketBall_Data_Project.Models.LeagueModel
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
