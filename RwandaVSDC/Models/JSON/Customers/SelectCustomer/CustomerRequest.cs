using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.Customers.SelectCustomer
{
    /// <summary>
    /// Search Customer Request
    /// </summary>
    public class CustomerRequest
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
        /// Customer Tin
        /// </summary>
        [Required]
        [StringLength(9)]
        [JsonPropertyName("custmTin")]
        public string? CustomerTin { get; set; }
    }
}
