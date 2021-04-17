using BasketBall_Data_Project.Models;
using System.Threading.Tasks;

namespace BasketBall_Data_Project.Services
{
    public interface IEventApiService
    {
        Task<Events> GetInfoAsync();
    }
}
