using BasketBall_Data_Project.Constants;
using BasketBall_Data_Project.Models.TeamModel;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BasketBall_Data_Project.Services
{
    public class TeamApiService : ITeamApiService
    {
        ISerializerService _serializerService;
        public TeamApiService(ISerializerService serializerService)
        {
            _serializerService = serializerService;
        }

        public async Task<Team> GetInfoAsync()
        {
            Team SportsTeams = null;
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{Config.ApiUrl}/teams"),
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
                SportsTeams = _serializerService.Deserialize<Team>(await response.Content.ReadAsStringAsync());
            }
            return SportsTeams;
        }
    }
}
