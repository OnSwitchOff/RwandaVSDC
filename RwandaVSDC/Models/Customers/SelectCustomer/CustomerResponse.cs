using RwandaVSDC.Models.ItemClass.SelectItemsClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Customers.SelectCustomer
{
    /// <summary>
    /// Search Customer Response
    /// </summary>
    public class CustomerResponse
    {
        /// <summary>
        /// Result Code
        /// </summary>
        [JsonPropertyName("resultCd")]
        [StringLength(3)]
        public string? ResultCode { get; set; }

        /// <summary>
        /// Result Message
        /// </summary>
        [JsonPropertyName("resultMsg")]
        public string? ResultMessage { get; set; }

        /// <summary>
        /// Result Date
        /// </summary>
        [JsonPropertyName("resultDt")]
        [StringLength(14)]
        public string? ResultDate { get; set; }

        [JsonPropertyName("data")]
        public CustomerResponseData? Data { get; set; }
    }


    public class CustomerResponseData
    {
        /// <summary>
        /// Taxpayer information list
        /// </summary>
        [JsonPropertyName("custList")]
        public List<TaxpayerInformation>? TaxpayerList { get; set; }
    }

    public class TaxpayerInformation
    {
        /// <summary>
        /// Taxpayer TIN
        /// </summary>
        [StringLength(9)]
        [JsonPropertyName("tin")]
        public string? Tin { get; set; }

        /// <summary>
        /// Taxpayer Name
        /// </summary>
        [StringLength(60)]
        [JsonPropertyName("taxprNm")]
        public string? TaxpayerName { get; set; }

        /// <summary>
        /// Taxpayer Status Code
        /// </summary>
        [StringLength(5)]
        [JsonPropertyName("taxprSttsCd")]
        public string? TaxpayerStatusCode { get; set; }

        /// <summary>
        /// Province Name
        /// </summary>
        [StringLength(100)]
        [JsonPropertyName("prvncNm")]
        public string? ProvinceName { get; set; }

        /// <summary>
        /// District Name
        /// </summary>
        [StringLength(100)]
        [JsonPropertyName("dstrtNm")]
        public string? DistrictName { get; set; }

        /// <summary>
        /// Sector Name
        /// </summary>
        [StringLength(100)]
        [JsonPropertyName("sctrNm")]
        public string? SectorName { get; set; }

        /// <summary>
        /// Location Description
        /// </summary>
        [JsonPropertyName("locDesc")]
        [StringLength(100)]
        public string? LocationDescription { get; set; }
    }
}
