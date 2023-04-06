using Newtonsoft.Json;
using RwandaVSDC.Services.JsonSerializer.Converters;
using System.Reflection;
using System.Text.Json;

namespace RwandaVSDC.Services.JsonSerializer
{
    public class JsonSerializerService : IJsonSerializerService
    {
        public string Serialize<T>(T obj)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Converters =
                {
                    new BigIntegerConverter(),
                    new BigIntegerNullableConverter()
                }
            };

            return System.Text.Json.JsonSerializer.Serialize(obj, options);            
        }

        public T? Deserialize<T>(string json)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                Converters =
                {
                    new BigIntegerConverter(),
                    new BigIntegerNullableConverter()
                }
            };

            return System.Text.Json.JsonSerializer.Deserialize<T>(json, options);
        }
    }
}
