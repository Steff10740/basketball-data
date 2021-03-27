using BasketBall_Data_Project.Models.TeamModel;
using System.Threading.Tasks;

namespace BasketBall_Data_Project.Services
{
    public interface ITeamApiService
    {
        Task<Team> GetInfoAsync();
    }
}
