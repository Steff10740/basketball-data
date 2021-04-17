using Newtonsoft.Json;
namespace BasketBall_Data_Project.Models.Event
{
    public class HomeScore
    {

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("display")]
        public int Display { get; set; }

        [JsonProperty("period_1")]
        public int Period1 { get; set; }

        [JsonProperty("normal_time")]
        public int NormalTime { get; set; }

        [JsonProperty("period_2")]
        public int? Period2 { get; set; }

        [JsonProperty("period_3")]
        public int? Period3 { get; set; }

        [JsonProperty("period_4")]
        public int? Period4 { get; set; }

        [JsonProperty("over_time")]
        public int? OverTime { get; set; }

        [JsonProperty("penalties")]
        public int? Penalties { get; set; }

        [JsonProperty("point")]
        public string Point { get; set; }
    }

    public class AwayScore
    {

        [JsonProperty("current")]
        public int Current { get; set; }

        [JsonProperty("display")]
        public int Display { get; set; }

        [JsonProperty("period_1")]
        public int Period1 { get; set; }

        [JsonProperty("normal_time")]
        public int NormalTime { get; set; }

        [JsonProperty("period_2")]
        public int? Period2 { get; set; }

        [JsonProperty("period_3")]
        public int? Period3 { get; set; }

        [JsonProperty("period_4")]
        public int? Period4 { get; set; }

        [JsonProperty("over_time")]
        public int? OverTime { get; set; }

        [JsonProperty("penalties")]
        public int? Penalties { get; set; }

        [JsonProperty("point")]
        public string Point { get; set; }
    }
}
