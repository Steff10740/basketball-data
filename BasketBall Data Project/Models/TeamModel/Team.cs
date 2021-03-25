using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace BasketBall_Data_Project.Models.TeamModel
{
    public class Team
    {
        [JsonProperty("data")]
        public ObservableCollection<Datum> Data { get; set; }
    }
}
