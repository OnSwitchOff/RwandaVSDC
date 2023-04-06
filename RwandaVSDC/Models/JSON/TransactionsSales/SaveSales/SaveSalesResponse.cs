using RwandaVSDC.Models.JSON.Imports.UpdateImportItems;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.TransactionsSales.SaveSales
{
    public class SaveSalesResponse
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
        public SaveSalesResponseData? Data { get; set; }
    }

    public class SaveSalesResponseData
    {
        public int? rcptNo { get; set; }
        public string? intrlData { get; set; }
        public string? rcptSign { get; set; }
        public int? totRcptNo { get; set; }
        public string? vsdcRcptPbctDate { get; set; }
        public string? sdcId { get; set; }
        public string? mrcNo { get; set; }
    }
}
