using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BasketBall_Data_Project.Models.SeasonModel
{
    public class SeasonList
    {
        [JsonProperty("data")]
        public ObservableCollection<Datum> Data { get; set; }
    }
}
