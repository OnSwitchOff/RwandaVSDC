using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.Branches.SaveBrancheInsurances
{
    public class SaveBranchInsuranceRequest
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
        /// Insurance Code
        /// </summary>
        [Required]
        [StringLength(10)]
        [JsonPropertyName("isrccCd")]
        public string? InsuranceCode { get; set; }

        /// <summary>
        /// Insurance Name
        /// </summary>
        [Required]
        [StringLength(100)]
        [JsonPropertyName("isrccNm")]
        public string? InsuranceName { get; set; }

        /// <summary>
        /// Premium Rate
        /// </summary>
        [Required]
        [JsonPropertyName("isrcRt")]
        public uint? PremiumRate { get; set; }

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
