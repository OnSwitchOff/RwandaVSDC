﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.ApiService
{
    public interface IApiService
    {
        Task<ApiResult<string>> GetSomeData(string apiUrl);
        Task<ApiResult<bool>> PostSomeData(string apiUrl, string data);
    }
}
