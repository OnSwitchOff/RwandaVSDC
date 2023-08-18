using RwandaVSDC.Models.JSON.ItemClass.SelectItemsClass;
using RwandaVSDC.Models.JSON.Notices.SelectNotices;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.ApiClients.NoticesApiClient
{
    public class NoticesApiClient : INoticesApiClient
    {
        private readonly IApiService _apiService;
        private readonly IJsonSerializerService _jsonSerializer;
        private readonly string _baseUrl;

        public NoticesApiClient(IApiService apiService, IJsonSerializerService jsonSerializer, string baseURL = "http://26.211.186.14:8080/rraVsdc_v1TestLatest/")
        {
            _apiService = apiService;
            _jsonSerializer = jsonSerializer;
            _baseUrl = baseURL;
        }

        public async Task<NoticeResponse?> SelectNoticesAsync(NoticeRequest requestBody)
        {
            var url = $"{_baseUrl}notices/selectNotices";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<NoticeResponse>(response.Data!);
            }

            return null;
        }
    }
}
