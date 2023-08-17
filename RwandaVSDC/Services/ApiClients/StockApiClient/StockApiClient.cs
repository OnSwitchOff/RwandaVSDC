using RwandaVSDC.Models.JSON.Stock.SaveStockItems;
using RwandaVSDC.Models.JSON.Stock.SaveStockMaster;
using RwandaVSDC.Models.JSON.Stock.SelectStockItems;
using RwandaVSDC.Models.JSON.TransactionsPurchase.SavePurchases;
using RwandaVSDC.Models.JSON.TransactionsPurchase.SelectTransactionsPurchaseSales;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.ApiClients.StockApiClient
{
    public class StockApiClient : IStockApiClient
    {
        private readonly IApiService _apiService;
        private readonly IJsonSerializerService _jsonSerializer;
        private readonly string _baseUrl;

        public StockApiClient(IApiService apiService, IJsonSerializerService jsonSerializer, string baseURL = "http://26.211.186.14:8080/rraVsdc_v1TestLatest/")
        {
            _apiService = apiService;
            _jsonSerializer = jsonSerializer;
            _baseUrl = baseURL;
        }

        public async Task<StockMovementResponse?> SelectStockItemsAsync(StockMovementRequest requestBody)
        {
            var url = $"{_baseUrl}/stock/selectStockItems";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<StockMovementResponse>(response.Data!);
            }

            return null;
        }

        public async Task<SaveStockResponse?> SaveStockItemsAsync(SaveStockRequest requestBody)
        {
            var url = "http://example.com/stock/saveStockItems";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<SaveStockResponse>(response.Data!);
            }

            return null;
        }

        public async Task<SaveStockMasterResponse?> SaveStockMasterAsync(SaveStockMasterRequest requestBody)
        {
            var url = "http://example.com/stockMaster/saveStockMaster";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<SaveStockMasterResponse>(response.Data!);
            }

            return null;
        }
    }
}
