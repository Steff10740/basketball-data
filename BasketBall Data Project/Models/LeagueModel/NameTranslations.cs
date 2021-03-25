using Newtonsoft.Json;
namespace XamarinAPI.Models
{
    public class NameTranslations
    {
        [JsonProperty("en")]
        public string En { get; set; }

        [JsonProperty("ru")]
        public string Ru { get; set; }
    }
}
