using RwandaVSDC.Models.JSON.Code.SelectCodes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.Items.SelectItems
{
    /// <summary>
    /// Search Item Response
    /// </summary>
    public class ItemResponse
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
        public ItemResponseData? Data { get; set; }
    }

    public class ItemResponseData
    {
        /// <summary>
        /// Item information list
        /// </summary>
        [JsonPropertyName("itemList")]
        public List<ItemInformation>? ItemList { get; set; }
    }

    public class ItemInformation
    {
        /// <summary>
        /// TIN
        /// </summary>
        [JsonPropertyName("tin")]
        [StringLength(9)]
        public string? Tin { get; set; }

        /// <summary>
        /// Item Code
        /// </summary>
        [JsonPropertyName("itemCd")]
        [StringLength(20)]
        public string? ItemCode { get; set; }

        /// <summary>
        /// Item Classification Code
        /// </summary>
        [JsonPropertyName("itemClsCd")]
        [StringLength(10)]
        public string? ItemClassificationCode { get; set; }

        /// <summary>
        /// Item Type Code
        /// </summary>
        [JsonPropertyName("itemTyCd")]
        [StringLength(20)]
        public string? ItemTypeCode { get; set; }

        /// <summary>
        /// Item Name
        /// </summary>
        [JsonPropertyName("itemNm")]
        [StringLength(200)]
        public string? ItemName { get; set; }

        /// <summary>
        /// Item Standard Name
        /// </summary>
        [JsonPropertyName("itemStdNm")]
        [StringLength(200)]
        public string? ItemStandardName { get; set; }

        /// <summary>
        /// Origin Place Code(Nation)
        /// </summary>
        [JsonPropertyName("orgnNatCd")]
        [StringLength(5)]
        public string? OriginPlaceCode { get; set; }

        /// <summary>
        /// Packaging Unit Code
        /// </summary>
        [JsonPropertyName("pkgUnitCd")]
        [StringLength(5)]
        public string? PackagingUnitCode { get; set; }

        /// <summary>
        /// Quantity Unit Code
        /// </summary>
        [JsonPropertyName("qtyUnitCd")]
        [StringLength(5)]
        public string? QuantityUnitCode { get; set; }

        /// <summary>
        /// Taxation Type Code
        /// </summary>
        [JsonPropertyName("taxTyCd")]
        [StringLength(5)]
        public string? TaxationTypeCode { get; set; }

        /// <summary>
        /// Batch Number
        /// </summary>
        [StringLength(10)]
        [JsonPropertyName("btchNo")]
        public string? BatchNumber { get; set; }

        /// <summary>
        /// Regist Branch Office ID
        /// </summary>
        [StringLength(10)]
        [JsonPropertyName("regBhfId")]
        public string? RegistBranchOfficeID { get; set; }

        /// <summary>
        /// Barcode
        /// </summary>
        [StringLength(20)]
        [JsonPropertyName("bcd")]
        public string? Barcode { get; set; }

        /// <summary>
        /// Default Unit Price
        /// </summary>
        [Required]
        [JsonPropertyName("dftPrc")]
        public decimal? DefaultUnitPrice { get; set; }

        /// <summary>
        /// Group1 Unit Price
        /// </summary>
        [JsonPropertyName("grpPrcL1")]
        public decimal? Group1UnitPrice { get; set; }

        /// <summary>
        /// Group2 Unit Price
        /// </summary>
        [JsonPropertyName("grpPrcL2")]
        public decimal? Group2UnitPrice { get; set; }

        /// <summary>
        /// Group3 Unit Price
        /// </summary>
        [JsonPropertyName("grpPrcL3")]
        public decimal? Group3UnitPrice { get; set; }

        /// <summary>
        /// Group4 Unit Price
        /// </summary>
        [JsonPropertyName("grpPrcL4")]
        public decimal? Group4UnitPrice { get; set; }

        /// <summary>
        /// Group5 Unit Price
        /// </summary>
        [JsonPropertyName("grpPrcL5")]
        public decimal? Group5UnitPrice { get; set; }


        /// <summary>
        /// Additional Information
        /// </summary>
        [StringLength(7)]
        [JsonPropertyName("addInfo")]
        public string? AdditionalInformation { get; set; }

        /// <summary>
        /// Safty Quantity
        /// </summary>
        [JsonPropertyName("sftyQty")]
        public decimal? SaftyQuantity { get; set; }

        /// <summary>
        /// Insurance Appicable(Y/N)
        /// </summary>
        [Required]
        [StringLength(1)]
        [JsonPropertyName("isrcAplcbYn")]
        public string? InsuranceAppicableYesNo { get; set; }

        /// <summary>
        /// RRA Modify Y/N 
        /// </summary>
        [Required]
        [StringLength(1)]
        [JsonPropertyName("rraModYn")]
        public string? RRAModifyYesNo { get; set; }

        /// <summary>
        /// Used (Y/N)
        /// </summary>
        [Required]
        [StringLength(1)]
        [JsonPropertyName("useYn")]
        public string? UsedYesNo { get; set; }
    }
}
