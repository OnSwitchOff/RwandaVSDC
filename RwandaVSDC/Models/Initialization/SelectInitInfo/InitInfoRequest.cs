using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Initialization.SelectInitInfo
{
    /// <summary>
    /// Initialization Request of VSDC device authentication
    /// </summary>
    public class InitInfoRequest
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
        /// Device Serial Number
        /// </summary>
        [Required]
        [StringLength(100)]
        [JsonPropertyName("dvcSrlNo")]
        public string? DvcSrlNo { get; set; }
    }
}
