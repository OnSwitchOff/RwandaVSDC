using RwandaVSDC.Models.JSON.TransactionsSales.SaveSales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.TransactionsPurchase.SavePurchases
{
    /// <summary>
    /// Save Purchase Response
    /// </summary>
    public class SavePurchaseResponse
    {
        /// <summary>
        /// Result Code
        /// </summary>
        [StringLength(3)]
        [JsonPropertyName("resultCd")]
        public string? ResultCode { get; set; }

        /// <summary>
        /// Result Message
        /// </summary>
        [JsonPropertyName("resultMsg")]
        public string? ResultMessage { get; set; }

        /// <summary>
        /// Result Date
        /// </summary>
        [StringLength(14)]
        [JsonPropertyName("resultDt")]
        public string? ResultDate { get; set; }

        [JsonPropertyName("data")]
        public SavePurchaseResponseData? Data { get; set; }
    }

    public class SavePurchaseResponseData
    {

    }

}
