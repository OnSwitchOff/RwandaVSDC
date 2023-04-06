using Microsoft.VisualBasic;
using RwandaVSDC.Models.Code.SelectCodes;
using RwandaVSDC.Models.Customers.SelectCustomer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Branches.SelectBranches
{
    /// <summary>
    /// Search Branch Response
    /// </summary>
    public class BranchResponse
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
        public BranchResponseData? Data { get; set; }
    }

    public class BranchResponseData
    {
        /// <summary>
        /// Branch Information list
        /// </summary>
        [JsonPropertyName("bhfList")]
        public List<BranchInformation>? BranchList { get; set; }
    }

    /// <summary>
    /// Branch Information
    /// </summary>
    public class BranchInformation
    {
        /// <summary>
        /// Taxpayer TIN
        /// </summary>
        [StringLength(9)]
        [JsonPropertyName("tin")]
        public string? Tin { get; set; }

        /// <summary>
        /// Branch Office ID
        /// </summary>
        [StringLength(2)]
        [JsonPropertyName("bhfId")]
        public string? BranchOfficeID { get; set; }

        /// <summary>
        /// Branch Office Name
        /// </summary>
        [StringLength(60)]
        [JsonPropertyName("bhfNm")]
        public string? BranchOfficeName { get; set; }

        /// <summary>
        /// Branch Status Code
        /// </summary>
        [StringLength(5)]
        [JsonPropertyName("bhfSttsCd")]
        public string? BranchStatusCode { get; set; }

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
        [StringLength(100)]
        public string? ManagerEmail { get; set; }

        /// <summary>
        /// Head Quarter 
        /// </summary>
        [JsonPropertyName("hqYn")]
        [StringLength(1)]
        public string? HeadQuarter { get; set; }
    }
}
