using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace XamarinAPI.Models
{
    public class Leagues
    {
        [JsonProperty("data")]
        public ObservableCollection<Datum> Data { get; set; }
        
        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }
    }
}
