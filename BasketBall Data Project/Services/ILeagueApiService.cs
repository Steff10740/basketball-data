using BasketBall_Data_Project.Models.LeagueModel;
using System.Threading.Tasks;

namespace XamarinAPI.Services
{
    public interface ILeagueApiService
    {
        Task<Leagues> GetBasketballLeaguesAsync();
    }
}
