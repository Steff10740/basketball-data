using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketBall_Data_Project.Models.Event
{
    public class TimeDetails
    {

        [JsonProperty("prefix")]
        public string Prefix { get; set; }

        [JsonProperty("initial")]
        public int Initial { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("extra")]
        public int Extra { get; set; }
    }
}
