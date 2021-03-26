using System;
using BasketBall_Data_Project.Models.LeagueModel;
using System.Net.Http;
using System.Threading.Tasks;

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
                Headers = {
                    {"x-rapidapi-key","9ded05c9aamsh3b4b3cdf643f767p1bf8d4jsnfffa5e85dd21"},
                    {"x-rapidapi-host","sportscore1.p.rapidapi.com"}
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
