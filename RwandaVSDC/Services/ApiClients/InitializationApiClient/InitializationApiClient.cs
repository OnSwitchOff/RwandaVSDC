using RwandaVSDC.Models.JSON.Code.SelectCodes;
using RwandaVSDC.Models.JSON.Initialization.SelectInitInfo;
using RwandaVSDC.Services.ApiClients.CodeApiClient;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.ApiClients.InitializationApiClient
{
    public class InitializationApiClient : IInitializationApiClient
    {
        private readonly IApiService _apiService;
        private readonly IJsonSerializerService _jsonSerializer;

        public InitializationApiClient(IApiService apiService, IJsonSerializerService jsonSerializer)
        {
            _apiService = apiService;
            _jsonSerializer = jsonSerializer;
        }

        public async Task<InitInfoResponse?> SelectInitInfoAsync(InitInfoRequest requestBody)
        {
            var url = "http://example.com/initializer/selectInitInfo";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<InitInfoResponse>(response.Data!);
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }

            return null;
        }
    }
}