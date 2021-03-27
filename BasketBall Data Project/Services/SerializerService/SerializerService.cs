using Newtonsoft.Json;

using System;

namespace BasketBall_Data_Project.Services
{
    public class SerializerService : ISerializerService
    {
        public T Deserialize<T>(string desData)
        {
            return JsonConvert.DeserializeObject<T>(desData);
        }

        public string Serialize(object data)
        {
            return JsonConvert.SerializeObject(data);
        }
    }
}
