using RwandaVSDC.Models.JSON.Items.SaveItems;
using RwandaVSDC.Models.JSON.Items.SelectItems;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.Stock.SelectStockItems
{
    /// <summary>
    /// Search Stock Movement Response
    /// </summary>
    public class StockMovementResponse
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
        public StockMovementData? Data { get; set; }
    }

    public class StockMovementData
    {
        /// <summary>
        /// Stock movement information list
        /// </summary>
        [JsonPropertyName("stockList")]
        public List<StockMovementInformation>? StockList { get; set; }
    }

    /// <summary>
    /// Stock movement information
    /// </summary>
    public class StockMovementInformation
    {
        /// <summary>
        /// Customer TIN
        /// </summary>
        [StringLength(9)]
        [JsonPropertyName("custTin")]
        public string? CustomerTin { get; set; }

        /// <summary>
        /// Customer Branch Office ID
        /// </summary>
        [StringLength(2)]
        [JsonPropertyName("custBhfId")]
        public string? CustomerBranchOfficeId { get; set; }

        /// <summary>
        /// Stored and released Number
        /// </summary>
        [JsonPropertyName("sarNo")]
        public BigInteger? StoredAndReleasedNumber { get; set; }

        /// <summary>
        /// Occurred Date(yyyyMMdd)
        /// </summary>
        [StringLength(8)]
        [JsonPropertyName("ocrnDt")]
        public string? OccurredDate { get; set; }

        /// <summary>
        /// Total Item Count
        /// </summary>
        [JsonPropertyName("totItemCnt")]
        public uint? TotalItemCount { get; set; }

        /// <summary>
        /// Total Supply Price
        /// </summary>
        [JsonPropertyName("totTaxblAmt")]
        public decimal? TotalTaxableAmount { get; set; }

        /// <summary>
        /// Total VAT
        /// </summary>
        [JsonPropertyName("totTaxAmt")]
        public decimal? TotalTaxAmount { get; set; }

        /// <summary>
        /// Total Amount
        /// </summary>
        [JsonPropertyName("totAmt")]
        public decimal? TotalAmount { get; set; }

        /// <summary>
        /// Remark
        /// </summary>
        [StringLength(400)]
        [JsonPropertyName("remark")]
        public string? Remark { get; set; }

        /// <summary>
        /// Stock movement item information list
        /// </summary>
        [JsonPropertyName("itemList")]
        public List<StockItemInformation>? ItemList { get; set; }
    }

    /// <summary>
    /// Stock movement item information list
    /// </summary>
    public class StockItemInformation
    {
        /// <summary>
        /// Item Sequence
        /// </summary>
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
        [JsonPropertyName("itemClsCd")]
        [StringLength(10)]
        public string? ItemClassificationCode { get; set; }

        /// <summary>
        /// Item Name
        /// </summary>
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
        [JsonPropertyName("pkgUnitCd")]
        [StringLength(5)]
        public string? PackagingUnitCode { get; set; }

        /// <summary>
        /// Package Quantity
        /// </summary>
        [JsonPropertyName("pkg")]
        public decimal? PackageQuantity { get; set; }

        /// <summary>
        /// Quantity Unit Code
        /// </summary>
        [JsonPropertyName("qtyUnitCd")]
        [StringLength(5)]
        public string? QuantityUnitCode { get; set; }

        /// <summary>
        /// Unit Quantity
        /// </summary>
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
        [JsonPropertyName("prc")]
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// Supply Amount
        /// </summary>
        [JsonPropertyName("splyAmt")]
        public decimal? SupplyAmount { get; set; }

        /// <summary>
        /// Discount Rate
        /// </summary>
        [JsonPropertyName("totDcAmt")]
        public decimal? DiscountRate { get; set; }

        /// <summary>
        /// Taxable Amount
        /// </summary>
        [JsonPropertyName("taxblAmt")]
        public decimal? TaxableAmount { get; set; }

        /// <summary>
        /// Taxation Type Code
        /// </summary>
        [JsonPropertyName("taxTyCd")]
        [StringLength(5)]
        public string? TaxationTypeCode { get; set; }

        /// <summary>
        /// Tax Amount
        /// </summary>
        [JsonPropertyName("taxAmt")]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// Total Amount
        /// </summary>
        [JsonPropertyName("totAmt")]
        public decimal? TotalAmount { get; set; }
    }
}
