using BasketBall_Data_Project.Models.TeamModel;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BasketBall_Data_Project.Services
{
    public class TeamApiService : ITeamApiService
    {
        ISerializerService serializerService = new SerializerService();
        public async Task<Team> GetInfoAsync(string endPoint)
        {
            Team SportsTeams = null;
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(endPoint),
                Headers =
                {
                    { "x-rapidapi-key", "4ea8d7e6f9mshd31033cdadc032bp1b5777jsn07633bf1455a" },
                    { "x-rapidapi-host", "sportscore1.p.rapidapi.com" },
                },
            };
            var client = new HttpClient();
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                SportsTeams = serializerService.Deserialize<Team>(await response.Content.ReadAsStringAsync());
            }
            return SportsTeams;
        }
    }
}
