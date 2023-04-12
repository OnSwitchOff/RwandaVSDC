using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.TransactionsSales.SaveSales
{
    /// <summary>
    /// Save Sales Request
    /// </summary>
    public class SaveSalesRequest
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
        public decimal? InvoiceNumber { get; set; }

        /// <summary>
        /// Original Invoice Number
        /// </summary>
        [Required]
        [JsonPropertyName("orgInvcNo")]
        public decimal? OriginalInvoiceNumber { get; set; }

        /// <summary>
        /// Customer TIN
        /// </summary>
        [Required]
        [StringLength(9)]
        [JsonPropertyName("custTin")]
        public string? CustomerTin { get; set; }

        /// <summary>
        /// Customer Name
        /// </summary>
        [Required]
        [StringLength(60)]
        [JsonPropertyName("custNm")]
        public string? CustomerName { get; set; }

        /// <summary>
        /// Sales Type Code
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("salesTyCd")]
        public string? SalesTypeCode { get; set; }

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
        [StringLength(5)]
        [JsonPropertyName("pmtTyCd")]
        public string? PaymentTypeCode { get; set; }

        /// <summary>
        /// Invoice Status Code
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("salesSttsCd")]
        public string? InvoiceStatusCode { get; set; }

        /// <summary>
        /// Validated Date (yyyyMMddhhmmss)
        /// </summary>
        [Required]
        [StringLength(14)]
        [JsonPropertyName("cfmDt")]
        public string? ValidatedDate { get; set; }

        /// <summary>
        /// Sale Date (yyyyMMdd)
        /// </summary>
        [Required]
        [StringLength(8)]
        [JsonPropertyName("salesDt")]
        public string? SaleDate { get; set; }

        /// <summary>
        /// Stock Released Date (yyyyMMddhhmmss)
        /// </summary>
        [StringLength(14)]
        [JsonPropertyName("stockRlsDt")]
        public string? StockReleasedDate { get; set; }

        /// <summary>
        /// Cancel Reqeuested Date (yyyyMMddhhmmss)
        /// </summary>
        [StringLength(14)]
        [JsonPropertyName("cnclReqDt")]
        public string? CancelReqeuestedDate { get; set; }

        /// <summary>
        /// Canceled Date (yyyyMMddhhmmss)
        /// </summary>
        [StringLength(14)]
        [JsonPropertyName("cnclDt")]
        public string? CanceledDate { get; set; }

        /// <summary>
        /// Refunded Date (yyyyMMddhhmmss)
        /// </summary>
        [StringLength(14)]
        [JsonPropertyName("rfdDt")]
        public string? RefundedDate { get; set; }

        /// <summary>
        /// Refunded Reason Code
        /// </summary>
        [StringLength(5)]
        [JsonPropertyName("rfdRsnCd")]
        public string? RefundedReasonCode { get; set; }

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
        /// Purchase Accept Y/N
        /// </summary>
        [StringLength(1)]
        [JsonPropertyName("prchrAcptcYn")]
        public string? PurchaseAcceptYesNo { get; set; }

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
        /// Modifier ID
        /// </summary>
        [Required]
        [StringLength(20)]
        [JsonPropertyName("modrId")]
        public string? ModifierId { get; set; }

        /// <summary>
        /// Modifier Name
        /// </summary>
        [Required]
        [StringLength(60)]
        [JsonPropertyName("modrNm")]
        public string? ModifierName { get; set; }



        [JsonPropertyName("receipt")]
        public SaveSaleRequestReceipt? Receipt { get; set; }

        /// <summary>
        /// Sales items information
        /// </summary>
        [JsonPropertyName("itemList")]
        public List<SaveSaleRequestItemInfo>? ItemList { get; set; }
    }

    public class SaveSaleRequestReceipt
    {
        /// <summary>
        /// Customer TIN
        /// </summary>
        [StringLength(9)]
        [JsonPropertyName("custTin")]
        public string? CustomerTin { get; set; }

        /// <summary>
        /// Customer Mobile Number
        /// </summary>
        [StringLength(20)]
        [JsonPropertyName("custMblNo")]
        public string? CustomerMobileNumber { get; set; }

        /// <summary>
        /// Report Number
        /// </summary>
        [Required]
        [JsonPropertyName("rptNo")]
        public decimal? ReportNumber { get; set; }

        /// <summary>
        /// Trade Name
        /// </summary>
        [StringLength(20)]
        [JsonPropertyName("trdeNm")]
        public string? TradeName { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [StringLength(200)]
        [JsonPropertyName("adrs")]
        public string? Address { get; set; }

        /// <summary>
        /// Top Message
        /// </summary>
        [StringLength(20)]
        [JsonPropertyName("topMsg")]
        public string? TopMessage { get; set; }

        /// <summary>
        /// Bottom Message
        /// </summary>
        [StringLength(20)]
        [JsonPropertyName("btmMsg")]
        public string? BottomMessage { get; set; }

        /// <summary>
        /// Whether buyers receive item or not.
        /// </summary>
        [Required]
        [StringLength(1)]
        [JsonPropertyName("prchrAcptcYn")]
        public string? BuyersReceiveItemYesNo { get; set; }
    }

    /// <summary>
    /// Sales item information
    /// </summary>
    public class SaveSaleRequestItemInfo
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
        /// Insurance Company Code
        /// </summary>
        [StringLength(10)]
        [JsonPropertyName("isrccCd")]
        public string? InsuranceCompanyCode { get; set; }

        /// <summary>
        /// Insurance Company Name
        /// </summary>
        [StringLength(100)]
        [JsonPropertyName("isrccNm")]
        public string? InsuranceCompanyName { get; set; }

        /// <summary>
        /// Insurance Rate
        /// </summary>
        [JsonPropertyName("isrcRt")]
        public int? InsuranceRate { get; set; }

        /// <summary>
        /// Insurance Amount
        /// </summary>
        [JsonPropertyName("isrcAmt")]
        public decimal? InsuranceAmount { get; set; }

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
