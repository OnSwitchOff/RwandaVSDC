using RwandaVSDC.Models.JSON.Imports.SelectImportItems;
using RwandaVSDC.Models.JSON.Imports.UpdateImportItems;
using RwandaVSDC.Models.JSON.Items.SaveItems;
using RwandaVSDC.Models.JSON.Items.SelectItems;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.ApiClients.ImportsApiClient
{
    public class ImportsApiClient : IImportsApiClient
    {
        private readonly IApiService _apiService;
        private readonly IJsonSerializerService _jsonSerializer;
        private readonly string _baseUrl;

        public ImportsApiClient(IApiService apiService, IJsonSerializerService jsonSerializer, string baseURL = "http://26.211.186.14:8080/rraVsdc_v1TestLatest/")
        {
            _apiService = apiService;
            _jsonSerializer = jsonSerializer;
            _baseUrl = baseURL;
        }

        public async Task<ImportItemResponse?> SelectItemsAsync(ImportItemRequest requestBody)
        {
            var url = $"{_baseUrl}imports/selectImportItems";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<ImportItemResponse>(response.Data!);
            }

            return null;
        }

        public async Task<UpdateImportItemResponse?> UpdateImportItemsAsync(UpdateImportItemRequest requestBody)
        {
            var url = $"{_baseUrl}imports/updateImportItems ";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<UpdateImportItemResponse>(response.Data!);
            }

            return null;
        }
    }
}
