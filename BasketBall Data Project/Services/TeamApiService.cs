using BasketBall_Data_Project.Constants;
using BasketBall_Data_Project.Models.TeamModel;
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
                    { Config.ApiKeyHeader, Config.ApiKey },
                    { Config.ApiHostHeader, Config.ApiHost },
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
