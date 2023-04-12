using RwandaVSDC.Models.JSON.Initialization.SelectInitInfo;
using RwandaVSDC.Models.JSON.ItemClass.SelectItemsClass;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.ApiClients.ItemClassApiClient
{
    public class ItemClassApiClient : IItemClassApiClient
    {
        private readonly IApiService _apiService;
        private readonly IJsonSerializerService _jsonSerializer;

        public ItemClassApiClient(IApiService apiService, IJsonSerializerService jsonSerializer)
        {
            _apiService = apiService;
            _jsonSerializer = jsonSerializer;
        }

        public async Task<ItemClassResponse?> SelectItemsClassAsync(ItemClassRequest requestBody)
        {
            var url = "http://example.com/itemClass/selectItemsClass";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<ItemClassResponse>(response.Data!);
            }

            return null;
        }
    }
}
