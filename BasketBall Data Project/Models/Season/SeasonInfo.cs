using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace BasketBall_Data_Project.Models.SeasonModel
{
    public class NameTranslations
    {

        [JsonProperty("en")]
        public string En { get; set; }

        [JsonProperty("ru")]
        public string Ru { get; set; }
    }

    public class Host
    {

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }
    }

    public class Fact
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class League
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
    }

    public class Data
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("year_start")]
        public int YearStart { get; set; }

        [JsonProperty("year_end")]
        public int YearEnd { get; set; }

        [JsonProperty("league")]
        public League League { get; set; }
    }
}
