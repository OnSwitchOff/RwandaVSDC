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
    public class CodeApiClient : ICodeApiCLient
    {
        private readonly IApiService _apiService;
        private readonly IJsonSerializerService _jsonSerializer;

        public CodeApiClient(IApiService apiService, IJsonSerializerService jsonSerializer)
        {
            _apiService = apiService;
            _jsonSerializer = jsonSerializer;
        }

        public async Task<CodeResponse?> SelectCodeAsync(CodeRequest codeRequest)
        {
            var url = "http://example.com/code/selectCodes";

            string request = _jsonSerializer.Serialize(codeRequest);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, request);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<CodeResponse>(response.Data!);
            }
            return null;
        }
    }
}
