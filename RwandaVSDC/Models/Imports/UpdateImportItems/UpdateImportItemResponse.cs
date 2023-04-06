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
    /// Update Import Item Response
    /// </summary>
    public class UpdateImportItemResponse
    {
        /// <summary>
        /// Result Code
        /// </summary>
        [StringLength(3)]
        [JsonPropertyName("resultCd")]
        public string? ResultCode { get; set; }

        /// <summary>
        /// Result Message
        /// </summary>
        [JsonPropertyName("resultMsg")]
        public string? ResultMessage { get; set; }

        /// <summary>
        /// Result Date
        /// </summary>
        [StringLength(14)]
        [JsonPropertyName("resultDt")]
        public string? ResultDate { get; set; }

        [JsonPropertyName("data")]
        public UpdateImportItemData? Data { get; set; }
    }

    public class UpdateImportItemData
    {

    }
}
