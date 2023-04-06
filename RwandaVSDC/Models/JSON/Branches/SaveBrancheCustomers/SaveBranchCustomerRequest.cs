using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.Branches.SaveBrancheCustomers
{
    /// <summary>
    /// Store branch custormers Request
    /// </summary>
    public class SaveBranchCustomerRequest
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
        /// Customer Number
        /// </summary>
        [Required]
        [StringLength(9)]
        [JsonPropertyName("custNo")]
        public string? CustomerNumber { get; set; }

        /// <summary>
        /// Customer TIN
        /// </summary>
        [Required]
        [StringLength(9)]
        [JsonPropertyName("custTin")]
        public string? CustomerTIN { get; set; }

        /// <summary>
        /// Customer Name
        /// </summary>
        [Required]
        [StringLength(60)]
        [JsonPropertyName("custNm")]
        public string? CustomerName { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [StringLength(300)]
        [JsonPropertyName("adrs")]
        public string? Address { get; set; }

        /// <summary>
        /// Contact
        /// </summary>
        [StringLength(20)]
        [JsonPropertyName("telNo")]
        public string? Contact { get; set; }

        /// <summary>
        /// Email 
        /// </summary>
        [StringLength(50)]
        [JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Fax Number 
        /// </summary>
        [StringLength(20)]
        [JsonPropertyName("faxNo")]
        public string? FaxNumber { get; set; }

        /// <summary>
        /// Used (Y/N)
        /// </summary>
        [Required]
        [StringLength(1)]
        [JsonPropertyName("useYn")]
        public string? UsedYesNo { get; set; }

        /// <summary>
        /// Remark 
        /// </summary>
        [StringLength(1000)]
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
