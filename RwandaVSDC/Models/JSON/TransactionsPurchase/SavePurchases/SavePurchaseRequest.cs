using RwandaVSDC.Models.JSON.TransactionsSales.SaveSales;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.TransactionsPurchase.SavePurchases
{
    /// <summary>
    /// Save Purchase Reques
    /// </summary>
    public class SavePurchaseRequest
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
        /// Invoice Number
        /// </summary>
        [Required]
        [JsonPropertyName("invcNo")]
        public BigInteger? InvoiceNumber { get; set; }

        /// <summary>
        /// Original Invoice Number
        /// </summary>
        [Required]
        [JsonPropertyName("orgInvcNo")]
        public BigInteger? OriginalInvoiceNumber { get; set; }

        /// <summary>
        /// Supplier TIN 
        /// </summary>
        [JsonPropertyName("spplrTin")]
        [StringLength(9)]
        public string? SupplierTin { get; set; }

        /// <summary>
        /// Supplier Branch ID
        /// </summary>
        [StringLength(2)]
        [JsonPropertyName("spplrBhfId")]
        public string? SupplierBranchId { get; set; }

        /// <summary>
        /// Supplier Name
        /// </summary>
        [StringLength(60)]
        [JsonPropertyName("spplrNm")]
        public string? SupplierName { get; set; }

        /// <summary>
        /// Supplier Invoice Number
        /// </summary>
        [JsonPropertyName("spplrInvcNo")]
        public BigInteger? SupplierInvoiceNumber { get; set; }

        ///// <summary>
        ///// Supplier SDC ID(for EBM2.0)
        ///// </summary>
        //[StringLength(12)]
        //[JsonPropertyName("spplrSdcId")]
        //public string? SupplierSdcId { get; set; }

        /// <summary>
        /// Registration Type Code 
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("regTyCd")]
        public string? RegistrationTypeCode { get; set; }

        /// <summary>
        /// Purchase Type Code 
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("pchsTyCd")]
        public string? PurchaseTypeCode { get; set; }

        /// <summary>
        /// Receipt Type Code 
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("rcptTyCd")]
        public string? ReceiptTypeCode { get; set; }

        /// <summary>
        /// Payment Type Code 
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("pmtTyCd")]
        public string? PaymentTypeCode { get; set; }

        /// <summary>
        /// Purchase Status Code 
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("pchsSttsCd")]
        public string? PurchaseStatusCode { get; set; }

        /// <summary>
        /// Validated Date("yyyyMMddhhmmss")
        /// </summary>
        [JsonPropertyName("cfmDt")]
        [StringLength(14)]
        public string? ValidatedDate { get; set; }

        /// <summary>
        /// Purchase Date("yyyyMMdd")
        /// </summary>
        [Required]
        [JsonPropertyName("pchsDt")]
        [StringLength(8)]
        public string? PurchaseDate { get; set; }

        /// <summary>
        /// Warehousing Date("yyyyMMddhhmmss")
        /// </summary>
        [JsonPropertyName("wrhsDt")]
        [StringLength(14)]
        public string? WarehousingDate { get; set; }

        /// <summary>
        /// Cancel Reqeuested Date("yyyyMMddhhmmss")
        /// </summary>
        [JsonPropertyName("cnclReqDt")]
        [StringLength(14)]
        public string? CancelReqeuestedDate { get; set; }

        /// <summary>
        /// Canceled Date("yyyyMMddhhmmss")
        /// </summary>
        [JsonPropertyName("cnclDt")]
        [StringLength(14)]
        public string? CanceledDate { get; set; }

        /// <summary>
        /// Refunded Date("yyyyMMddhhmmss")
        /// </summary>
        [JsonPropertyName("rfdDt")]
        [StringLength(14)]
        public string? RefundedDate { get; set; }

        /// <summary>
        /// Total Item Count
        /// </summary>
        [Required]
        [JsonPropertyName("totItemCnt")]
        public uint? TotalItemCount { get; set; }

        /// <summary>
        /// Taxable Amount A
        /// </summary>
        [Required]
        [JsonPropertyName("taxblAmtA")]
        public decimal? TaxableAmountA { get; set; }

        /// <summary>
        /// Taxable Amount B
        /// </summary>
        [Required]
        [JsonPropertyName("taxblAmtB")]
        public decimal? TaxableAmountB { get; set; }

        /// <summary>
        /// Taxable Amount C
        /// </summary>
        [Required]
        [JsonPropertyName("taxblAmtC")]
        public decimal? TaxableAmountC { get; set; }

        /// <summary>
        /// Taxable Amount D
        /// </summary>
        [Required]
        [JsonPropertyName("taxblAmtD")]
        public decimal? TaxableAmountD { get; set; }

        /// <summary>
        /// Tax Rate A
        /// </summary>
        [Required]
        [JsonPropertyName("taxRtA")]
        public decimal? TaxRateA { get; set; }

        /// <summary>
        /// Tax Rate B
        /// </summary>
        [Required]
        [JsonPropertyName("taxRtB")]
        public decimal? TaxRateB { get; set; }

        /// <summary>
        /// Tax Rate C
        /// </summary>
        [Required]
        [JsonPropertyName("taxRtC")]
        public decimal? TaxRateC { get; set; }

        /// <summary>
        /// Tax Rate D
        /// </summary>
        [Required]
        [JsonPropertyName("taxRtD")]
        public decimal? TaxRateD { get; set; }

        /// <summary>
        /// Tax Amt A
        /// </summary>
        [Required]
        [JsonPropertyName("taxAmtA")]
        public decimal? TaxAmtA { get; set; }

        /// <summary>
        /// Tax Amt B
        /// </summary>
        [Required]
        [JsonPropertyName("taxAmtB")]
        public decimal? TaxAmtB { get; set; }

        /// <summary>
        /// Tax Amt C
        /// </summary>
        [Required]
        [JsonPropertyName("taxAmtC")]
        public decimal? TaxAmtC { get; set; }

        /// <summary>
        /// Tax Amt D
        /// </summary>
        [Required]
        [JsonPropertyName("taxAmtD")]
        public decimal? TaxAmtD { get; set; }

        /// <summary>
        /// Total Taxable Amount
        /// </summary>
        [Required]
        [JsonPropertyName("totTaxblAmt")]
        public decimal? TotalTaxableAmount { get; set; }

        /// <summary>
        /// Total Tax Amount
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
        public string? RegistrantId { get; set; }

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
        /// Purchase items information list
        /// </summary>
        [JsonPropertyName("itemList")]
        public List<SavePurchaseRequestItemInfo>? ItemList { get; set; }
    }

    /// <summary>
    /// Purchase items information
    /// </summary>
    public class SavePurchaseRequestItemInfo
    {
        /// <summary>
        /// Item Sequence Number
        /// </summary>
        [Required]
        [JsonPropertyName("itemSeq")]
        public uint? ItemSequenceNumber { get; set; }

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
        [StringLength(10)]
        [JsonPropertyName("itemClsCd")]
        public string? ItemClassificationCode { get; set; }


        /// <summary>
        /// Item Name
        /// </summary>
        [Required]
        [StringLength(200)]
        [JsonPropertyName("itemNm")]
        public string? ItemName { get; set; }

        /// <summary>
        /// Barcode
        /// </summary>
        [StringLength(20)]
        [JsonPropertyName("bcd")]
        public string? Barcode { get; set; }

        /// <summary>
        /// Supplier Item Classification Code
        /// </summary>
        [StringLength(10)]
        [JsonPropertyName("spplrItemClsCd")]
        public string? SupplierItemClassificationCode { get; set; }

        /// <summary>
        /// Supplier Item Code
        /// </summary>
        [StringLength(20)]
        [JsonPropertyName("spplrItemCd")]
        public string? SupplierItemCode { get; set; }

        /// <summary>
        /// Supplier Item Name
        /// </summary>
        [StringLength(200)]
        [JsonPropertyName("spplrItemNm")]
        public string? SupplierItemName { get; set; }

        /// <summary>
        /// Packaging Unit Code
        /// </summary>
        [StringLength(5)]
        [JsonPropertyName("pkgUnitCd")]
        public string? PackagingUnitCode { get; set; }

        /// <summary>
        /// Package
        /// </summary>
        [Required]
        [JsonPropertyName("pkg")]
        public decimal? Package { get; set; }

        /// <summary>
        /// Quantity Unit Code
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("qtyUnitCd")]
        public string? QuantityUnitCode { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [Required]
        [JsonPropertyName("qty")]
        public decimal? Quantity { get; set; }

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
        /// Discount Rate
        /// </summary>
        [Required]
        [JsonPropertyName("dcRt")]
        public decimal? DiscountRate { get; set; }

        /// <summary>
        /// Discount Amount
        /// </summary>
        [Required]
        [JsonPropertyName("dcAmt")]
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
        [StringLength(5)]
        [JsonPropertyName("taxTyCd")]
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

        /// <summary>
        /// Item Expired Date("yyyyMMdd")
        /// </summary>
        [Required]
        [JsonPropertyName("itemExprDt")]
        [StringLength(8)]
        public string? ItemExpiredDate { get; set; }
    }
}
