using RwandaVSDC.Models.JSON.Stock.SelectStockItems;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.Stock.SaveStockItems
{
    /// <summary>
    /// Save Stock In/Out Request
    /// </summary>
    public class SaveStockRequest
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
        /// Stored and released Number
        /// </summary>
        [Required]
        [JsonPropertyName("sarNo")]
        public BigInteger? StoredAndReleasedNumber { get; set; }

        /// <summary>
        /// Stored and released Number
        /// </summary>
        [Required]
        [JsonPropertyName("orgSarNo")]
        public BigInteger? OriginalStoredAndReleasedNumber { get; set; }

        /// <summary>
        /// Registration Type Code
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("regTyCd")]
        public string? RegistrationTypeCode { get; set; }

        /// <summary>
        /// Customer TIN
        /// </summary>
        [StringLength(9)]
        [JsonPropertyName("custTin")]
        public string? CustomerTin { get; set; }

        /// <summary>
        /// Customer name
        /// </summary>
        [StringLength(100)]
        [JsonPropertyName("custNm")]
        public string? CustomerName { get; set; }

        /// <summary>
        /// Customer Branch Office ID
        /// </summary>
        [StringLength(2)]
        [JsonPropertyName("custBhfId")]
        public string? CustomerBranchOfficeId { get; set; }

        /// <summary>
        /// Stored and released Type Code
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("sarTyCd")]
        public string? StoredAndReleasedTypeCode { get; set; }

        /// <summary>
        /// Occurred Date(yyyyMMdd)
        /// </summary>
        [Required]
        [StringLength(8)]
        [JsonPropertyName("ocrnDt")]
        public string? OccurredDate { get; set; }

        /// <summary>
        /// Total Item Count
        /// </summary>
        [Required]
        [JsonPropertyName("totItemCnt")]
        public uint? TotalItemCount { get; set; }
        /// <summary>
        /// Total Supply Price
        /// </summary>
        [Required]
        [JsonPropertyName("totTaxblAmt")]
        public decimal? TotalTaxableAmount { get; set; }

        /// <summary>
        /// Total VAT
        /// </summary>
        [Required]
        [JsonPropertyName("totTaxAmt")]
        public decimal? TotalTaxAmount { get; set; }

        /// <summary>
        /// Total Amount
        /// </summary>
        [Required]
        [JsonPropertyName("totAmt")]
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// Remark
        /// </summary>
        [StringLength(400)]
        [JsonPropertyName("remark")]
        public string? Remark { get; set; }


        /// <summary>
        /// Registrant ID 
        /// </summary>
        [Required]
        [StringLength(20)]
        [JsonPropertyName("regrId")]
        public string? RegistrantId { get; set; }

        /// <summary>
        /// Registrant Name
        /// </summary>
        [Required]
        [StringLength(60)]
        [JsonPropertyName("regrNm")]
        public string? RegistrantName { get; set; }

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
        public string? ModifierId { get; set; }

        /// <summary>
        /// Save Stock item information list
        /// </summary>
        [JsonPropertyName("itemList")]
        public List<SaveStockItemInformation>? ItemList { get; set; }
    }

    /// <summary>
    ///  Save Stock item information list
    /// </summary>
    public class SaveStockItemInformation
    {
        /// <summary>
        /// Item Sequence
        /// </summary>
        [Required]
        [JsonPropertyName("itemSeq")]
        public uint? ItemSequence { get; set; }

        /// <summary>
        /// Item Code
        /// </summary>        
        [JsonPropertyName("itemCd")]
        [StringLength(20)]
        public string? ItemCode { get; set; }

        /// <summary>
        /// Item Classification Code
        /// </summary>
        [Required]
        [JsonPropertyName("itemClsCd")]
        [StringLength(10)]
        public string? ItemClassificationCode { get; set; }

        /// <summary>
        /// Item Name
        /// </summary>
        [Required]
        [JsonPropertyName("itemNm")]
        [StringLength(200)]
        public string? ItemName { get; set; }

        /// <summary>
        /// Barcode
        /// </summary>
        [StringLength(20)]
        [JsonPropertyName("bcd")]
        public string? Barcode { get; set; }

        /// <summary>
        /// Packaging Unit Code
        /// </summary>
        [Required]
        [JsonPropertyName("pkgUnitCd")]
        [StringLength(5)]
        public string? PackagingUnitCode { get; set; }

        /// <summary>
        /// Package Quantity
        /// </summary>
        [Required]
        [JsonPropertyName("pkg")]
        public decimal? PackageQuantity { get; set; }

        /// <summary>
        /// Quantity Unit Code
        /// </summary>
        [Required]
        [JsonPropertyName("qtyUnitCd")]
        [StringLength(5)]
        public string? QuantityUnitCode { get; set; }

        /// <summary>
        /// Unit Quantity
        /// </summary>
        [Required]
        [JsonPropertyName("qty")]
        public decimal? UnitQuantity { get; set; }

        /// <summary>
        /// Item Expired Date
        /// </summary>
        [JsonPropertyName("itemExprDt")]
        [StringLength(8)]
        public string? ItemExpiredDate { get; set; }

        /// <summary>
        /// Unit Price
        /// </summary>
        [Required]
        [JsonPropertyName("prc")]
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// Supply Amount
        /// </summary>
        [Required]
        [JsonPropertyName("splyAmt")]
        public decimal? SupplyAmount { get; set; }

        /// <summary>
        /// Discount Amount
        /// </summary>
        [Required]
        [JsonPropertyName("totDcAmt")]
        public decimal? DiscountAmount { get; set; }

        /// <summary>
        /// Taxable Amount
        /// </summary>
        [Required]
        [JsonPropertyName("taxblAmt")]
        public decimal? TaxableAmount { get; set; }

        /// <summary>
        /// Taxation Type Code
        /// </summary>
        [Required]
        [JsonPropertyName("taxTyCd")]
        [StringLength(5)]
        public string? TaxationTypeCode { get; set; }

        /// <summary>
        /// Tax Amount
        /// </summary>
        [Required]
        [JsonPropertyName("taxAmt")]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// Total Amount
        /// </summary>
        [Required]
        [JsonPropertyName("totAmt")]
        public decimal? TotalAmount { get; set; }
    }
}
