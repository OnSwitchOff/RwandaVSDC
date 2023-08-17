﻿using RwandaVSDC.Models.JSON.Items.SaveItems;
using RwandaVSDC.Models.JSON.Items.SelectItems;
using RwandaVSDC.Models.JSON.Notices.SelectNotices;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.ApiClients.ItemsApiClient
{
    public class ItemsApiClient : IItemsApiClient
    {
        private readonly IApiService _apiService;
        private readonly IJsonSerializerService _jsonSerializer;
        private readonly string _baseUrl;

        public ItemsApiClient(IApiService apiService, IJsonSerializerService jsonSerializer, string baseURL = "http://26.211.186.14:8080/rraVsdc_v1TestLatest/")
        {
            _apiService = apiService;
            _jsonSerializer = jsonSerializer;
            _baseUrl = baseURL;
        }

        public async Task<ItemResponse?> SelectItemsAsync(ItemRequest requestBody)
        {
            var url = $"{_baseUrl}/items/selectItems";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<ItemResponse>(response.Data!);
            }

            return null;
        }

        public async Task<SaveItemResponse?> SaveItemsAsync(SaveItemRequest requestBody)
        {
            var url = "http://example.com/items/saveItems";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<SaveItemResponse>(response.Data!);
            }

            return null;
        }
    }
}
