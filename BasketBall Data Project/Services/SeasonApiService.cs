using System;
using System.Net.Http;
using BasketBall_Data_Project.Models.SeasonModel;
using System.Threading.Tasks;

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
                    { "x-rapidapi-key", "8aaee18d33msh73133a98dbb4908p146d53jsn17633aea599f" }, 
                    { "x-rapidapi-host", "sportscore1.p.rapidapi.com" }, 
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
