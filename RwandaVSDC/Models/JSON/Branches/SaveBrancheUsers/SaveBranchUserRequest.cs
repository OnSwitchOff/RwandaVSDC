using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.Branches.SaveBrancheUsers
{
    /// <summary>
    /// Save Branch User Request
    /// </summary>
    public class SaveBranchUserRequest
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
        /// User ID
        /// </summary>
        [Required]
        [StringLength(20)]
        [JsonPropertyName("userId")]
        public string? UserID { get; set; }

        /// <summary>
        /// User Name
        /// </summary>
        [Required]
        [StringLength(60)]
        [JsonPropertyName("userNm")]
        public string? UserName { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [Required]
        [StringLength(255)]
        [JsonPropertyName("pwd")]
        public string? Password { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [StringLength(200)]
        [JsonPropertyName("adrs")]
        public string? Address { get; set; }

        /// <summary>
        /// Contact
        /// </summary>
        [StringLength(20)]
        [JsonPropertyName("cntc")]
        public string? Contact { get; set; }

        /// <summary>
        /// Authority Code 
        /// </summary>
        [StringLength(100)]
        [JsonPropertyName("authCd")]
        public string? AuthorityCode { get; set; }

        /// <summary>
        /// Remark 
        /// </summary>
        [StringLength(2000)]
        [JsonPropertyName("remark")]
        public string? Remark { get; set; }

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
