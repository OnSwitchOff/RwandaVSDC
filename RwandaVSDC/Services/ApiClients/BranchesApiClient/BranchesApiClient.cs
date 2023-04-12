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

        public BranchesApiClient(IApiService apiService, IJsonSerializerService jsonSerializer)
        {
            _apiService = apiService;
            _jsonSerializer = jsonSerializer;
        }

        public async Task<BranchResponse?> SelectBranchesAsync(BranchRequest requestBody)
        {
            var url = "http://example.com/branches/selectBranches";

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
            var url = "http://example.com/branches/saveBrancheCustomers";

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
            var url = "http://example.com/branches/saveBrancheUsers";

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
            var url = "http://example.com/branches/saveBrancheInsurances ";

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
