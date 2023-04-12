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

        public NoticesApiClient(IApiService apiService, IJsonSerializerService jsonSerializer)
        {
            _apiService = apiService;
            _jsonSerializer = jsonSerializer;
        }

        public async Task<NoticeResponse?> SelectNoticesAsync(NoticeRequest requestBody)
        {
            var url = "http://example.com/notices/selectNotices";

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
