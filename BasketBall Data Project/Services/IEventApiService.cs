using BasketBall_Data_Project.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasketBall_Data_Project.Services
{
    public interface IEventApiService
    {
        Task<Event> GetInfoAsync();
    }
}
