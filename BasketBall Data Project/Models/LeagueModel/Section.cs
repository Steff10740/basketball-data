using System.Collections.Generic;
using Newtonsoft.Json;
namespace BasketBall_Data_Project.Models.LeagueModel
{
    public class Section
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_translations")]
        public SectionNameTranslations NameTranslations { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }
    }
}
