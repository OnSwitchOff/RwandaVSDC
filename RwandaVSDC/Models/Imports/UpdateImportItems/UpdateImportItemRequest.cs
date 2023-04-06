using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Imports.UpdateImportItems
{
    /// <summary>
    /// Update Import Item Request
    /// </summary>
    public class UpdateImportItemRequest
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
        /// Task Code
        /// </summary>
        [Required]
        [StringLength(50)]
        [JsonPropertyName("taskCd")]
        public string? TaskCode  { get; set; }

        /// <summary>
        /// Declaration Date
        /// </summary>
        [Required]
        [StringLength(8)]
        [JsonPropertyName("dclDe")]
        public string? DeclarationDate { get; set; }

        /// <summary>
        /// Item Sequence
        /// </summary>
        [Required]
        [JsonPropertyName("itemSeq")]
        public uint? ItemSequence { get; set; }

        /// <summary>
        /// HS Code
        /// </summary>
        [Required]
        [StringLength(17)]
        [JsonPropertyName("hsCd")]
        public string? HSCode { get; set; }

        /// <summary>
        /// Item Classification Code
        /// </summary>
        [Required]
        [StringLength(10)]
        [JsonPropertyName("itemClsCd")]
        public string? ItemClassificationCode { get; set; }

        /// <summary>
        /// Item Code
        /// </summary>
        [Required]
        [StringLength(20)]
        [JsonPropertyName("itemCd")]
        public string? ItemCode { get; set; }

        /// <summary>
        /// Import Item Status Code
        /// </summary>
        [Required]
        [StringLength(5)]
        [JsonPropertyName("imptItemSttsCd")]
        public string? ImportItemStatusCode { get; set; }

        /// <summary>
        /// Remark
        /// </summary>
        [StringLength(400)]
        [JsonPropertyName("remark")]
        public string? Remark { get; set; }

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
