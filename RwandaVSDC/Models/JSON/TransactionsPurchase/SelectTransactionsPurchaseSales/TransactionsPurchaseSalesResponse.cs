using RwandaVSDC.Models.JSON.Items.SelectItems;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.TransactionsPurchase.SelectTransactionsPurchaseSales
{
    /// <summary>
    /// Search Purchase/Sales Response
    /// </summary>
    public class TransactionsPurchaseSalesResponse
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
        public TransactionsPurchaseSalesData? Data { get; set; }
    }

    public class TransactionsPurchaseSalesData
    {
        /// <summary>
        /// Transactions Purchase Sales information list
        /// </summary>
        [JsonPropertyName("saleList")]
        public List<TransactionsPurchaseSalesInformation>? SaleList { get; set; }
    }

    /// <summary>
    /// Transaction purchase salesv information
    /// </summary>
    public class TransactionsPurchaseSalesInformation
    {
        /// <summary>
        /// Supplier TIN 
        /// </summary>
        [JsonPropertyName("spplrTin")]
        [StringLength(9)]
        public string? SupplierTin { get; set; }

        /// <summary>
        /// Supplier Name
        /// </summary>
        [JsonPropertyName("spplrNm")]
        [StringLength(60)]
        public string? SupplierName { get; set; }

        /// <summary>
        /// Supplier Branch ID
        /// </summary>
        [JsonPropertyName("spplrBhfId")]
        [StringLength(2)]
        public string? SupplierBranchId { get; set; }

        /// <summary>
        /// Supplier invoice number
        /// </summary>
        [JsonPropertyName("spplrInvcNo")]
        public BigInteger? SupplierInvoiceNumber { get; set; }

        /// <summary>
        /// spplrSdcId
        /// </summary>
        [JsonPropertyName("spplrSdcId")]
        public string? SpplrSdcId { get; set; }

        /// <summary>
        /// spplrMrcNo
        /// </summary>
        [JsonPropertyName("spplrMrcNo")]
        public string? SpplrMrcNo { get; set; }

        /// <summary>
        /// Receipt Type Code
        /// </summary>
        [JsonPropertyName("rcptTyCd")]
        [StringLength(5)]
        public string? ReceiptTypeCode { get; set; }

        /// <summary>
        /// Payment Type Code
        /// </summary>
        [JsonPropertyName("pmtTyCd")]
        [StringLength(5)]
        public string? PaymentTypeCode { get; set; }

        /// <summary>
        /// Validated Date("yyyy-MM-dd HH:mm:ss")
        /// </summary>
        [JsonPropertyName("cfmDt")]
        [StringLength(19)]
        public string? ValidatedDate { get; set; }

        /// <summary>
        /// Sale Date("yyyyMMdd")
        /// </summary>
        [JsonPropertyName("salesDt")]
        [StringLength(8)]
        public string? SaleDate { get; set; }

        /// <summary>
        /// Stock Released Date("yyyy-MM-dd HH:mm:ss")
        /// </summary>
        [JsonPropertyName("stockRlsDt")]
        [StringLength(19)]
        public string? StockReleasedDate { get; set; }

        /// <summary>
        /// Total Item Count
        /// </summary>
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
        /// Transaction purchase  sales item information list
        /// </summary>
        [JsonPropertyName("itemList")]
        public List<TransactionsPurchaseSalesItemInformation>? ItemList { get; set; }
    }

    /// <summary>
    /// Transaction purchase sales item information
    /// </summary>
    public class TransactionsPurchaseSalesItemInformation
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
        /// Packaging Unit Code
        /// </summary>
        [Required]
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
        /// Taxation Type Code
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("taxTyCd")]
        public string? TaxationTypeCode { get; set; }

        /// <summary>
        /// Taxable Amount
        /// </summary>
        [Required]
        [JsonPropertyName("taxblAmt")]
        public decimal? TaxableAmount { get; set; }

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
