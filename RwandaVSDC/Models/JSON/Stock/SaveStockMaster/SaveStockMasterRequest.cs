using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.Stock.SaveStockMaster
{
    /// <summary>
    /// Save Stock Master Request
    /// </summary>
    public class SaveStockMasterRequest
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
        public string? ItemCode  { get; set; }

        /// <summary>
        /// Remain Quantity 
        /// </summary>
        [Required]
        [JsonPropertyName("rsdQty")]
        public decimal? RemainQuantity { get; set; }

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
    }
}
