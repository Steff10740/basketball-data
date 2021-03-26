using System;
using System.Collections.Generic;
using System.Text;

namespace BasketBall_Data_Project.Services
{
    public interface ISerializerService
    {
        string Serialize(object data);
       T Deserialize<T>(string DesData);
    }
}
