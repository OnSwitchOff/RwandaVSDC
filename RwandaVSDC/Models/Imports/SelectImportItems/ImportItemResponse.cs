using RwandaVSDC.Models.Items.SelectItems;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Imports.SelectImportItems
{
    /// <summary>
    ///  Import Items Response
    /// </summary>
    public class ImportItemResponse
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
        public ImportItemResponseData? Data { get; set; }
    }

    public class ImportItemResponseData
    {
        /// <summary>
        /// Import Item information list
        /// </summary>
        [JsonPropertyName("itemList")]
        public List<ImportItemInformation>? ItemList { get; set; }
    }

    /// <summary>
    /// Import Item information
    /// </summary>
    public class ImportItemInformation
    {
        /// <summary>
        /// Task Code
        /// </summary>
        [JsonPropertyName("taskCd")]
        [StringLength(50)]
        public string? TaskCode { get; set; }

        /// <summary>
        /// Declaration Date
        /// </summary>
        [JsonPropertyName("dclDe")]
        [StringLength(8)]
        public string? DeclarationDate  { get; set; }

        /// <summary>
        /// Item Sequence
        /// </summary>
        [JsonPropertyName("itemSeq")]
        public uint? ItemSequence { get; set; }

        /// <summary>
        /// Declaration Number
        /// </summary>
        [JsonPropertyName("dclNo")]
        [StringLength(50)]
        public string? DeclarationNumber { get; set; }

        /// <summary>
        /// HS Code
        /// </summary>
        [JsonPropertyName("hsCd")]
        [StringLength(17)]
        public string? HSCode { get; set; }

        /// <summary>
        /// Item Name
        /// </summary>
        [JsonPropertyName("itemNm")]
        [StringLength(500)]
        public string? ItemName { get; set; }

        /// <summary>
        /// Import Item Status Code
        /// </summary>
        [JsonPropertyName("imptItemsttsCd")]
        [StringLength(5)]
        public string? ImportItemStatusCode { get; set; }

        /// <summary>
        /// Origin Place Code(Nation)
        /// </summary>
        [JsonPropertyName("orgnNatCd")]
        [StringLength(5)]
        public string? OriginPlaceCode { get; set; }

        /// <summary>
        /// Export Nation Code
        /// </summary>
        [JsonPropertyName("exptNatCd")]
        [StringLength(5)]
        public string? ExportNationCode { get; set; }

        /// <summary>
        /// Package
        /// </summary>
        [JsonPropertyName("pkg")]
        public decimal? Package { get; set; }

        /// <summary>
        /// Packaging Unit Code
        /// </summary>
        [JsonPropertyName("pkgUnitCd")]
        [StringLength(5)]
        public string? PackagingUnitCode { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonPropertyName("qty")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Quantity Unit Code
        /// </summary>
        [JsonPropertyName("qtyUnitCd")]
        [StringLength(5)]
        public string? QuantityUnitCode { get; set; }

        /// <summary>
        /// Gross Weight
        /// </summary>
        [JsonPropertyName("totWt")]
        public decimal? GrossWeight { get; set; }

        /// <summary>
        /// Net Weight
        /// </summary>
        [JsonPropertyName("netWt")]
        public decimal? NetWeight { get; set; }

        /// <summary>
        /// Supplier's name
        /// </summary>
        [JsonPropertyName("spplrNm")]
        [StringLength(500)]
        public string? SupplierName { get; set; }

        /// <summary>
        /// Agent's name
        /// </summary>
        [JsonPropertyName("agntNm")]
        [StringLength(500)]
        public string? AgentName { get; set; }

        /// <summary>
        /// Invoice Foreign Currency Amount
        /// </summary>
        [JsonPropertyName("invcFcurAmt")]
        public decimal? InvoiceForeignCurrencyAmount { get; set; }

        /// <summary>
        /// Invoice Foreign Currency
        /// </summary>
        [JsonPropertyName("invcFcurCd")]
        [StringLength(5)]
        public string? InvoiceForeignCurrency { get; set; }

        /// <summary>
        /// invcFcurExcrt
        /// </summary>
        [JsonPropertyName("invcFcurExcrt")]
        public decimal? InvcFcurExcrt { get; set; }
    }
}
