using RwandaVSDC.Models.JSON.Items.SaveItems;
using RwandaVSDC.Models.JSON.Items.SelectItems;
using RwandaVSDC.Models.JSON.TransactionsPurchase.SavePurchases;
using RwandaVSDC.Models.JSON.TransactionsPurchase.SelectTransactionsPurchaseSales;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.ApiClients.TransactionsPurchaseApiClient
{
    public class TransactionsPurchaseApiClient : ITransactionsPurchaseApiClient
    {
        private readonly IApiService _apiService;
        private readonly IJsonSerializerService _jsonSerializer;

        public TransactionsPurchaseApiClient(IApiService apiService, IJsonSerializerService jsonSerializer)
        {
            _apiService = apiService;
            _jsonSerializer = jsonSerializer;
        }

        public async Task<TransactionsPurchaseSalesResponse?> SelectTransactionsPurchaseSalesAsync(TransactionsPurchaseSalesRequest requestBody)
        {
            var url = "http://example.com/trnsSales/saveSales";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<TransactionsPurchaseSalesResponse>(response.Data!);
            }

            return null;
        }

        public async Task<SavePurchaseResponse?> SavePurchaseAsync(SavePurchaseRequest requestBody)
        {
            var url = "http://example.com/trnsPurchase/selectTrnsPurchaseSales";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<SavePurchaseResponse>(response.Data!);
            }

            return null;
        }
    }
}
