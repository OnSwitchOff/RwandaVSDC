using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Data;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    public class ApiResponseCodeValueObject : ValueObject<ApiResponseCodeValueObject>
    {
        private readonly string _code;
        private readonly string _system;
        private readonly string _description;

        public ApiResponseCodeValueObject(string code, string system, string description)
        {
            _code = code;
            _system = system;
            _description = description;
        }

        public string Code => _code;
        public string System => _system;
        public string Description => _description;

        public static ApiResponseCodeValueObject Create(string apiResponseCode)
        {
            if (!ApiResponseCodes.Codes.ContainsKey(apiResponseCode))
            {
                throw new ArgumentException($"Invalid api response code: {apiResponseCode}");
            }

            ApiResponseCodeInfo apiResponseCodeInfo = ApiResponseCodes.Codes[apiResponseCode];
            return new ApiResponseCodeValueObject(apiResponseCodeInfo.Code, apiResponseCodeInfo.System, apiResponseCodeInfo.Description);
        }

        protected override bool EqualsCore(ApiResponseCodeValueObject other)
        {
            return _code == other._code &&
                   _system == other._system &&
                   _description == other._description;
        }

        protected override int GetHashCodeCore()
        {
            return HashCode.Combine(_code, _system, _description);
        }
    }
}