using Newtonsoft.Json;
namespace BasketBall_Data_Project.Models.LeagueModel
{
    public class Fact
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
