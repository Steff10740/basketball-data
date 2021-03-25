using System.Collections.Generic;
using Newtonsoft.Json;
namespace XamarinAPI.Models
{
    public class Datum
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_translations")]
        public NameTranslations NameTranslations { get; set; }

        [JsonProperty("has_logo")]
        public bool HasLogo { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("host")]
        public Host Host { get; set; }

        [JsonProperty("tennis_points")]
        public int TennisPoints { get; set; }

        [JsonProperty("facts")]
        public IList<Fact> Facts { get; set; }

        [JsonProperty("sport")]
        public Sport Sport { get; set; }

        [JsonProperty("section")]
        public Section Section { get; set; }

    }
}
