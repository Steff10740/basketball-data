using System;
using BasketBall_Data_Project.Models.LeagueModel;
using System.Net.Http;
using System.Threading.Tasks;
using BasketBall_Data_Project.Constants;

namespace BasketBall_Data_Project.Services
{
    public class LeagueApiService : ILeagueApiService
    {
        ISerializerService _serializerService;
        public LeagueApiService(ISerializerService serializerService)
        {
            _serializerService = serializerService;
        }

        public async Task<Leagues> GetInfoAsync()
        {
            Leagues basketballLeagues = null;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{Config.ApiUrl}/leagues"),
                Headers = 
                {
                    { Config.ApiKeyHeader, Config.ApiKey },
                    { Config.ApiHostHeader, Config.ApiHost },
                },
            };
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                basketballLeagues = _serializerService.Deserialize<Leagues>(await response.Content.ReadAsStringAsync());
            }
            return basketballLeagues;
        }
    }
}
