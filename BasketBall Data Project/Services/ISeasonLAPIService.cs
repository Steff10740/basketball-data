using System.Threading.Tasks;
using BasketBall_Data_Project.Models.SeasonModel;

namespace BasketBall_Data_Project.Services
{
    public interface ISeasonLAPIService
    {
        Task<SeasonList> GetSeasonInfoAsync();
        
    }
}
