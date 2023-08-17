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
        private readonly string _baseUrl;

        public ItemClassApiClient(IApiService apiService, IJsonSerializerService jsonSerializer, string baseURL = "http://26.211.186.14:8080/rraVsdc_v1TestLatest/")
        {
            _apiService = apiService;
            _jsonSerializer = jsonSerializer;
            _baseUrl = baseURL;
        }

        public async Task<ItemClassResponse?> SelectItemsClassAsync(ItemClassRequest requestBody)
        {
            var url = $"{_baseUrl}/itemClass/selectItemsClass";

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
