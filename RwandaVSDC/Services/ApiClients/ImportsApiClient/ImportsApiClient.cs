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

        public ImportsApiClient(IApiService apiService, IJsonSerializerService jsonSerializer)
        {
            _apiService = apiService;
            _jsonSerializer = jsonSerializer;
        }

        public async Task<ImportItemResponse?> SelectItemsAsync(ImportItemRequest requestBody)
        {
            var url = "http://example.com/imports/selectImportItems";

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
            var url = "http://example.com/imports/updateImportItems ";

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
