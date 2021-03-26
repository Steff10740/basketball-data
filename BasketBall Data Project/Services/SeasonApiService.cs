using System;
using System.Net.Http;
using BasketBall_Data_Project.Models.SeasonModel;
using System.Threading.Tasks;
using BasketBall_Data_Project.Constants;

namespace BasketBall_Data_Project.Services
{
    public class SeasonApiService : ISeasonApiService
    {
        ISerializerService serializerService = new SerializerService();

        public async Task<SeasonList> GetInfoAsync(string endPoint)
        {
            SeasonList season = null;
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
            if  (response.IsSuccessStatusCode)
            {
                season = serializerService.Deserialize<SeasonList>(await response.Content.ReadAsStringAsync());
            }
            return season;
        }
    }
}
