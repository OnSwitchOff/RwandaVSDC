using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.ApiService
{
    public class HttpApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public HttpApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ApiResult<string>> GetSomeData(string apiUrl)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();

                return new ApiResult<string>
                {
                    Success = true,
                    Data = responseData
                };
            }
            else
            {
                string errorMessage = $"Failed to get data from {apiUrl}. Status code: {response.StatusCode}. Reason: {response.ReasonPhrase}";

                return new ApiResult<string>
                {
                    Success = false,
                    ErrorMessage = errorMessage
                };
            }
        }

        public async Task<ApiResult<bool>> PostSomeData(string apiUrl, string data)
        {
            HttpContent httpContent = new StringContent(data);
            HttpResponseMessage response = await _httpClient.PostAsync(apiUrl, httpContent);

            if (response.IsSuccessStatusCode)
            {
                return new ApiResult<bool>
                {
                    Success = true,
                    Data = true
                };
            }
            else
            {
                string errorMessage = $"Failed to post data to {apiUrl}. Status code: {response.StatusCode}. Reason: {response.ReasonPhrase}";

                return new ApiResult<bool>
                {
                    Success = false,
                    ErrorMessage = errorMessage
                };
            }
        }
    }
}
