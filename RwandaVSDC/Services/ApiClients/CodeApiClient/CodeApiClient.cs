using RwandaVSDC.Models.JSON.Code.SelectCodes;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.ApiClients.CodeApiClient
{
    public class CodeApiClient : ICodeApiClient
    {
        private readonly IApiService _apiService;
        private readonly IJsonSerializerService _jsonSerializer;
        private readonly string _baseUrl;

        public CodeApiClient(IApiService apiService, IJsonSerializerService jsonSerializer, string baseURL = "http://localhost:8081/rraVsdc_v1")
        {
            _apiService = apiService;
            _jsonSerializer = jsonSerializer;
            _baseUrl = baseURL;
        }

        public async Task<CodeResponse?> SelectCodeAsync(CodeRequest codeRequest)
        {
            var url = $"{_baseUrl}/code/selectCodes";

            string request = _jsonSerializer.Serialize(codeRequest);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, request);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<CodeResponse>(response.Data!);
            }
            else
            {
                throw new Exception(response.ErrorMessage);
            }

            return null;
        }
    }
}
