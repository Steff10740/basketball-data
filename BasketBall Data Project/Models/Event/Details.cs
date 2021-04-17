using Newtonsoft.Json;

namespace BasketBall_Data_Project.Models.Event
{
    public class Details
    {

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_i_s_o")]
        public string CountryISO { get; set; }

        [JsonProperty("date_of_birth")]
        public string DateOfBirth { get; set; }

        [JsonProperty("birthplace")]
        public string Birthplace { get; set; }

        [JsonProperty("plays")]
        public string Plays { get; set; }

        [JsonProperty("residence")]
        public string Residence { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("height_meters")]
        public double HeightMeters { get; set; }

        [JsonProperty("prize_current")]
        public string PrizeCurrent { get; set; }

        [JsonProperty("prize_total")]
        public string PrizeTotal { get; set; }

        [JsonProperty("prize_current_euros")]
        public int PrizeCurrentEuros { get; set; }

        [JsonProperty("prize_total_euros")]
        public int PrizeTotalEuros { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }
    }
}
