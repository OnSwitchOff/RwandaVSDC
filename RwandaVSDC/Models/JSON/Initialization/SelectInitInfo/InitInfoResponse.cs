using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.Initialization.SelectInitInfo
{
    /// <summary>
    /// Response of VSDC device authentication
    /// </summary>
    public class InitInfoResponse
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
        public InitInfoResponseData? Data { get; set; }
    }

    public class InitInfoResponseData
    {
        [JsonPropertyName("info")]
        public InitInfoResponseInfo? Info { get; set; }
    }

    public class InitInfoResponseInfo
    {
        /// <summary>
        /// TIN
        /// </summary>
        [JsonPropertyName("tin")]
        [StringLength(9)]
        public string? Tin { get; set; }

        /// <summary>
        /// Taxpayer Name
        /// </summary>
        [JsonPropertyName("taxprNm")]
        [StringLength(60)]
        public string? TaxpayerName { get; set; }

        /// <summary>
        /// Business Activity
        /// </summary>
        [JsonPropertyName("bsnsActv")]
        [StringLength(100)]
        public string? BusinessActivity { get; set; }

        /// <summary>
        /// Branch Office Id 
        /// </summary>
        [JsonPropertyName("bhfId")]
        [StringLength(2)]
        public string? BranchOfficeId { get; set; }

        /// <summary>
        /// Branch Office Name 
        /// </summary>
        [JsonPropertyName("bhfNm")]
        [StringLength(60)]
        public string? BranchOfficeName { get; set; }

        /// <summary>
        /// Branch Date Created
        /// </summary>
        [JsonPropertyName("bhfOpenDt")]
        [StringLength(8)]
        public string? BranchDateCreated { get; set; }

        /// <summary>
        /// Province Name
        /// </summary>
        [JsonPropertyName("prvncNm")]
        [StringLength(100)]
        public string? ProvinceName { get; set; }

        /// <summary>
        /// District Name
        /// </summary>
        [JsonPropertyName("dstrtNm")]
        [StringLength(100)]
        public string? DistrictName { get; set; }

        /// <summary>
        /// Sector Name
        /// </summary>
        [JsonPropertyName("sctrNm")]
        [StringLength(100)]
        public string? SectorName { get; set; }

        /// <summary>
        /// Location Description 
        /// </summary>
        [JsonPropertyName("locDesc")]
        [StringLength(100)]
        public string? LocationDescription { get; set; }

        /// <summary>
        /// Head Quarter 
        /// </summary>
        [JsonPropertyName("hqYn")]
        [StringLength(1)]
        public string? HeadQuarter { get; set; }

        /// <summary>
        /// Manager Name 
        /// </summary>
        [JsonPropertyName("mgrNm")]
        [StringLength(60)]
        public string? ManagerName { get; set; }

        /// <summary>
        /// Manager Contact Number
        /// </summary>
        [JsonPropertyName("mgrTelNo")]
        [StringLength(20)]
        public string? ManagerContactNumber { get; set; }

        /// <summary>
        /// Manage Email
        /// </summary>
        [JsonPropertyName("mgrEmail")]
        [StringLength(50)]
        public string? ManagerEmail { get; set; }


        /// <summary>
        /// SDC id
        /// </summary>
        [JsonPropertyName("sdcId")]
        [StringLength(12)]
        public string? SdcId { get; set; }

        /// <summary>
        /// MRC No 
        /// </summary>
        [JsonPropertyName("mrcNo")]
        [StringLength(11)]
        public string? MrcNo { get; set; }


        /// <summary>
        /// Device id
        /// </summary>
        [JsonPropertyName("dvcId")]
        [StringLength(20)]
        public string? DeviceId { get; set; }

        /// <summary>
        /// INTERNAL KEY
        /// </summary>
        [JsonPropertyName("intrlKey")]
        [StringLength(255)]
        public string? InternalKey { get; set; }

        /// <summary>
        /// SIGN KEY
        /// </summary>
        [JsonPropertyName("signKey")]
        [StringLength(255)]
        public string? SignKey { get; set; }

        /// <summary>
        /// Communication KEY
        /// </summary>
        [JsonPropertyName("cmcKey")]
        [StringLength(255)]
        public string? CommunicationKey { get; set; }

        /// <summary>
        /// Last Purchase Invoice Number
        /// </summary>
        [JsonPropertyName("lastPchsInvcNo")]
        public ulong? LastPurchaseInvoiceNumber { get; set; }

        /// <summary>
        /// Last Sale Receipt Number
        /// </summary>
        [JsonPropertyName("lastSaleRcptNo")]
        public ulong? LastSaleReceiptNumber { get; set; }

        /// <summary>
        /// Last CIS Invoice Number
        /// </summary>
        [JsonPropertyName("lastInvcNo")]
        public ulong? LastCisInvoiceNumber { get; set; }

        /// <summary>
        /// Last Sale Invoice Number
        /// </summary>
        [JsonPropertyName("lastSaleInvcNo")]
        public ulong? LastSaleInvoiceNumber { get; set; }

        /// <summary>
        /// Last Training Invoice Number
        /// </summary>
        [JsonPropertyName("lastTrainInvcNo")]
        public ulong? LastTrainingInvoiceNumber { get; set; }

        /// <summary>
        /// Last Proforma Invoice Number
        /// </summary>
        [JsonPropertyName("lastProfrmInvcNo")]
        public ulong? LastProformaInvoiceNumber { get; set; }

        /// <summary>
        /// Last Copy Invoice Number
        /// </summary>
        [JsonPropertyName("lastCopyInvcNo")]
        public ulong? LastCopyInvoiceNumber { get; set; }
    }
}
