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

        public async Task<ApiResult<string>> GetSomeDataAsync(string apiUrl)
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

        public async Task<ApiResult<string>> PostSomeDataAsync(string apiUrl, string data)
        {
            HttpContent httpContent = new StringContent(data,Encoding.UTF8,"application/json");
            HttpResponseMessage response = await _httpClient.PostAsync(apiUrl, httpContent);


            string responseData = await response.Content.ReadAsStringAsync();
            string separator = "=========================================\n";
            AppendTextToFile("Communication_log.txt", $"DateTime: {DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss")}\nURL: {apiUrl}\nRequestBody:\n{data}\nResponse:\n{responseData}\n{separator}");

            if (response.IsSuccessStatusCode)
            {
                return new ApiResult<string>
                {
                    Success = true,
                    Data = responseData
                };
            }
            else
            {
                string errorMessage = $"Failed to post data to {apiUrl}. Status code: {response.StatusCode}. Reason: {response.ReasonPhrase}";
                return new ApiResult<string>
                {
                    Success = false,
                    Data = responseData,
                    ErrorMessage = errorMessage
                };
            }


        }


        private void AppendTextToFile(string filePath, string textToAppend)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(textToAppend);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
