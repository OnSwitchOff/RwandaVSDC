using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.ApiService
{
    public interface IApiService
    {
        Task<ApiResult<string>> GetSomeDataAsync(string apiUrl);
        Task<ApiResult<string>> PostSomeDataAsync(string apiUrl, string data);
    }
}
