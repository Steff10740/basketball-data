using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
namespace BasketBall_Data_Project.Models.LeagueModel
{
    public class SectionNameTranslations
    {
        [JsonProperty("en")]
        public string En { get; set; }
        
        [JsonProperty("ru")]
        public string Ru { get; set; }

        [JsonProperty("de")]
        public string De { get; set; }

        [JsonProperty("es")]
        public string Es { get; set; }

        [JsonProperty("fr")]
        public string Fr { get; set; }

        [JsonProperty("zh")]
        public string Zh { get; set; }

        [JsonProperty("tr")]
        public string Tr { get; set; }

        [JsonProperty("el")]
        public string El { get; set; }

        [JsonProperty("it")]
        public string It { get; set; }

        [JsonProperty("nl")]
        public string Nl { get; set; }

        [JsonProperty("pt")]
        public string Pt { get; set; }
    }
}
