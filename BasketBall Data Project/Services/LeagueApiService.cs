using System;
using BasketBall_Data_Project.Models.LeagueModel;
using System.Net.Http;
using System.Threading.Tasks;
using BasketBall_Data_Project.Constants;

namespace BasketBall_Data_Project.Services
{
    public class LeagueApiService : ILeagueApiService
    {
        ISerializerService serializerService = new SerializerService();
        public async Task<Leagues> GetInfoAsync(string endPoint)
        {
            Leagues basketballLeagues = null;
            var client = new HttpClient();
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
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                basketballLeagues = serializerService.Deserialize<Leagues>(await response.Content.ReadAsStringAsync());
            }
            return basketballLeagues;
        }
    }
}
