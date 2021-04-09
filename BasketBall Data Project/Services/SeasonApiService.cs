using System;
using System.Net.Http;
using BasketBall_Data_Project.Models.SeasonModel;
using System.Threading.Tasks;
using BasketBall_Data_Project.Constants;

namespace BasketBall_Data_Project.Services
{
    public class SeasonApiService : ISeasonApiService
    {
        ISerializerService _serializerService;
        public SeasonApiService(ISerializerService serializerService)
        {
            _serializerService = serializerService;
        }

        public async Task<SeasonList> GetInfoAsync()
        {
            SeasonList season = null;
            var request = new HttpRequestMessage 
            { 
                Method = HttpMethod.Get, 
                RequestUri = new Uri($"{Config.ApiUrl}/seasons/1"), 
                Headers = 
                {
                    { Config.ApiKeyHeader, Config.ApiKey },
                    { Config.ApiHostHeader, Config.ApiHost },
                }, 
            };
            var client = new HttpClient();
            var response = await client.SendAsync(request);
            if  (response.IsSuccessStatusCode)
            {
                season = _serializerService.Deserialize<SeasonList>(await response.Content.ReadAsStringAsync());
            }
            return season;
        }
    }
}
