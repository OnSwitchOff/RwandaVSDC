using RwandaVSDC.Models.Items.SelectItems;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.TransactionsPurchase.SelectTransactionsPurchaseSales
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
        public string? SupplierTin  { get; set; }

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
        /// Receipt Type Code
        /// </summary>
        [JsonPropertyName("rcptTyCd")]
        [StringLength(2)]
        public string? ReceiptTypeCode { get; set; }
    }
}
