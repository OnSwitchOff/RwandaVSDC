﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Code.SelectCodes
{
    /// <summary>
    /// Search code Request
    /// </summary>
    public class CodeRequest
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
        /// Last Request Date
        /// </summary>
        [Required]
        [StringLength(14)]
        [JsonPropertyName("lastReqDt")]
        public string? LastRequestDate { get; set; }
    }
}
