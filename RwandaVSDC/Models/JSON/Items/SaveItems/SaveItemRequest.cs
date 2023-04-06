using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.Items.SaveItems
{
    /// <summary>
    /// Save Item Request
    /// </summary>
    public class SaveItemRequest
    {
        /// <summary>
        /// TIN
        /// </summary>
        [Required]
        [StringLength(9)]
        [JsonPropertyName("tin")]
        public string? Tin { get; set; }

        /// <summary>
        /// Branch ID
        /// </summary>
        [Required]
        [StringLength(2)]
        [JsonPropertyName("bhfId")]
        public string? BranchId { get; set; }

        /// <summary>
        /// Item Code
        /// </summary>
        [Required]
        [StringLength(20)]
        [JsonPropertyName("itemCd")]
        public string? ItemCode { get; set; }

        /// <summary>
        /// Item Classification Code
        /// </summary>
        [Required]
        [StringLength(10)]
        [JsonPropertyName("itemClsCd")]
        public string? ItemClassificationCode { get; set; }

        /// <summary>
        /// Item Type Code
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("itemTyCd")]
        public string? ItemTypeCode { get; set; }

        /// <summary>
        /// Item Name
        /// </summary>
        [Required]
        [StringLength(200)]
        [JsonPropertyName("itemNm")]
        public string? ItemName { get; set; }

        /// <summary>
        /// Item Standard Name
        /// </summary>
        [StringLength(200)]
        [JsonPropertyName("itemStdNm")]
        public string? ItemStandardName { get; set; }

        /// <summary>
        /// Origin Place Code
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("orgnNatCd")]
        public string? OriginPlaceCode { get; set; }

        /// <summary>
        /// Packaging Unit Code
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("pkgUnitCd")]
        public string? PackagingUnitCode { get; set; }

        /// <summary>
        /// Quantity Unit Code
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("qtyUnitCd")]
        public string? QuantityUnitCode { get; set; }

        /// <summary>
        /// Taxation Type Code
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("taxTyCd")]
        public string? TaxationTypeCode { get; set; }

        /// <summary>
        /// Batch Number
        /// </summary>
        [StringLength(10)]
        [JsonPropertyName("btchNo")]
        public string? BatchNumber { get; set; }

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
        /// Used (Y/N)
        /// </summary>
        [Required]
        [StringLength(1)]
        [JsonPropertyName("useYn")]
        public string? UsedYesNo { get; set; }

        /// <summary>
        /// Registrant Name
        /// </summary>
        [Required]
        [StringLength(60)]
        [JsonPropertyName("regrNm")]
        public string? RegistrantName { get; set; }

        /// <summary>
        /// Registrant ID 
        /// </summary>
        [Required]
        [StringLength(20)]
        [JsonPropertyName("regrId")]
        public string? RegistrantID { get; set; }

        /// <summary>
        /// Modifier Name 
        /// </summary>
        [Required]
        [StringLength(60)]
        [JsonPropertyName("modrNm")]
        public string? ModifierName { get; set; }

        /// <summary>
        /// Modifier ID
        /// </summary>
        [Required]
        [StringLength(20)]
        [JsonPropertyName("modrId")]
        public string? ModifierID { get; set; }
    }

}
