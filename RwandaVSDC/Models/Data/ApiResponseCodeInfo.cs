using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Data
{
    public class ApiResponseCodeInfo
    {
        private readonly string _code;
        private readonly string _system;
        private readonly string _description;
        public ApiResponseCodeInfo(string code, string system, string description)
        {
            _code = code;
            _system = system;
            _description = description;
        }
        public string Code => _code;
        public string System => _system;
        public string Description => _description;
    }
}
