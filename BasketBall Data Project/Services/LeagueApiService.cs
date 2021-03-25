using System;
using System.Collections.Generic;
using System.Text;
using BasketBall_Data_Project.Models.LeagueModel;
using System.Net.Http;
using System.Threading.Tasks;
using BasketBall_Data_Project.Services;

namespace XamarinAPI.Services
{
    public class LeagueApiService : ILeagueApiService
    {
        ISerializerService serializerService = new SerializerService();
        public async Task<Leagues> GetBasketballLeaguesAsync()
        {
            Leagues basketballLeagues = null;
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://sportscore1.p.rapidapi.com/sports/3/leagues"),
                Headers = {
                    {"x-rapidapi-key","9ded05c9aamsh3b4b3cdf643f767p1bf8d4jsnfffa5e85dd21"},
                    {"x-rapidapi-host","sportscore1.p.rapidapi.com"}
                },
            };
            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                basketballLeagues = serializerService.Deserialize<Leagues>(await response.Content.ReadAsStringAsync());
                //JsonConvert.DeserializeObject<Leagues>(await response.Content.ReadAsStringAsync());
            }
            return basketballLeagues;
        }
    }
}
