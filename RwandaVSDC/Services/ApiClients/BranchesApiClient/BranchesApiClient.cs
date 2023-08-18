using RwandaVSDC.Models.JSON.Branches.SaveBrancheCustomers;
using RwandaVSDC.Models.JSON.Branches.SaveBrancheInsurances;
using RwandaVSDC.Models.JSON.Branches.SaveBrancheUsers;
using RwandaVSDC.Models.JSON.Branches.SelectBranches;
using RwandaVSDC.Models.JSON.Notices.SelectNotices;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.ApiClients.BranchesApiClient
{
    public class BranchesApiClient : IBranchesApiClient
    {
        private readonly IApiService _apiService;
        private readonly IJsonSerializerService _jsonSerializer;
        private readonly string _baseUrl;

        public BranchesApiClient(IApiService apiService, IJsonSerializerService jsonSerializer, string baseURL = "http://26.211.186.14:8080/rraVsdc_v1TestLatest/")
        {
            _apiService = apiService;
            _jsonSerializer = jsonSerializer;
            _baseUrl = baseURL;
        }

        public async Task<BranchResponse?> SelectBranchesAsync(BranchRequest requestBody)
        {
            var url = $"{_baseUrl}branches/selectBranches";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<BranchResponse>(response.Data!);
            }

            return null;
        }

        public async Task<SaveBranchCustomerResponse?> SaveBrancheCustomersAsync(SaveBranchCustomerRequest requestBody)
        {
            var url = $"{_baseUrl}branches/saveBrancheCustomers";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<SaveBranchCustomerResponse>(response.Data!);
            }

            return null;
        }

        public async Task<SaveBranchUserResponse?> SaveBrancheUsersAsync(SaveBranchUserRequest requestBody)
        {
            var url = $"{_baseUrl}branches/saveBrancheUsers";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<SaveBranchUserResponse>(response.Data!);
            }
            return null;
        }

        public async Task<SaveBranchInsuranceResponse?> SaveBrancheInsurancesAsync(SaveBranchInsuranceRequest requestBody)
        {
            var url = $"{_baseUrl}branches/saveBrancheInsurances ";

            string requestBodyString = _jsonSerializer.Serialize(requestBody);

            ApiResult<string> response = await _apiService.PostSomeDataAsync(url, requestBodyString);

            if (response.Success == true)
            {
                return _jsonSerializer.Deserialize<SaveBranchInsuranceResponse>(response.Data!);
            }

            return null;
        }
    }
}
