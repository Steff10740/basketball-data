using Newtonsoft.Json;
namespace BasketBall_Data_Project.Models.LeagueModel
{
    public class NameTranslations
    {
        [JsonProperty("en")]
        public string En { get; set; }

        [JsonProperty("ru")]
        public string Ru { get; set; }
    }
}
