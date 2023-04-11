using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Data
{
    public static class ApiResponseCodes
    {
        public static IReadOnlyDictionary<string, ApiResponseCodeInfo> Codes = InitDictionary();
        private static Dictionary<string, ApiResponseCodeInfo> InitDictionary()
        {
            return new Dictionary<string, ApiResponseCodeInfo>() 
            {
                { "000" , new ApiResponseCodeInfo("000", "Server", "It is succeeded") },
                { "001" , new ApiResponseCodeInfo("001", "Server", "There is no search result") },
                { "891" , new ApiResponseCodeInfo("891", "Client", "An error occurred while Request URL is created.") },
                { "892" , new ApiResponseCodeInfo("892", "Client", "An error occurred while Request Header data is created.") },
                { "893" , new ApiResponseCodeInfo("893", "Client", "An error occurred while Request Body data is created.") },
                { "894" , new ApiResponseCodeInfo("894", "Client", "An error regarding server communication occurred.") },
                { "895" , new ApiResponseCodeInfo("895", "Client", "An error regarding unallowed Request Method occurred.") },
                { "896" , new ApiResponseCodeInfo("896", "Client", "An error regarding Request Status occurred.") },
                { "899" , new ApiResponseCodeInfo("899", "Client", "An error regarding Client occurred.") },
                { "900" , new ApiResponseCodeInfo("900", "Server", "There is no Header information") },
                { "901" , new ApiResponseCodeInfo("901", "Server", "It is not valid device") },
                { "902" , new ApiResponseCodeInfo("902", "Server", "This device is installed") },
                { "903" , new ApiResponseCodeInfo("903", "Server", "Only VSDC device can be verified.") },
                { "910" , new ApiResponseCodeInfo("910", "Server", "Request parameter error") },
                { "911" , new ApiResponseCodeInfo("911", "Server", "There is no request full text") },
                { "912" , new ApiResponseCodeInfo("912", "Server", "There is a request Method error.") },
                { "921" , new ApiResponseCodeInfo("921", "Server", "Sales or sales invoice data which is declared cannot be received.") },
                { "922" , new ApiResponseCodeInfo("922", "Server", "Sales invoice data can be received after receiving the sales data.") },
                { "990" , new ApiResponseCodeInfo("990", "Server", "The maxium number of views are exceeded") },
                { "991" , new ApiResponseCodeInfo("991", "Server", "There is an error during registration") },
                { "992" , new ApiResponseCodeInfo("992", "Server", "There is an error during modification") },
                { "993" , new ApiResponseCodeInfo("993", "Server", "There is an error during deletion") },
                { "994" , new ApiResponseCodeInfo("994", "Server", "There is an overlapped Data") },
                { "995" , new ApiResponseCodeInfo("995", "Server", "There is no downloaded file") },
                { "999" , new ApiResponseCodeInfo("999", "Server", "There is an unknown error. Please ask it administrator") }
            };
        }
    }
}
