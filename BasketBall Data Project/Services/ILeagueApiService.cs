using BasketBall_Data_Project.Models.LeagueModel;
using System.Threading.Tasks;

namespace BasketBall_Data_Project.Services
{
    public interface ILeagueApiService
    {
        Task<Leagues> GetInfoAsync(string endPoint);
    }
}
