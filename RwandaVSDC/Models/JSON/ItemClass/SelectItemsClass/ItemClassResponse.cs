using RwandaVSDC.Models.JSON.Code.SelectCodes;
using RwandaVSDC.Models.JSON.Initialization.SelectInitInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.ItemClass.SelectItemsClass
{
    /// <summary>
    /// Search Classification Response
    /// </summary>
    public class ItemClassResponse
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
        public ItemClassResponseData? Data { get; set; }
    }

    public class ItemClassResponseData
    {
        /// <summary>
        /// Item classification information list
        /// </summary>
        [JsonPropertyName("itemClsList")]
        public List<ItemClassificationInformation>? ItemClassList { get; set; }
    }

    /// <summary>
    /// Item classification information
    /// </summary>
    public class ItemClassificationInformation
    {
        /// <summary>
        /// Item Class Code 
        /// </summary>
        [JsonPropertyName("itemClsCd")]
        [StringLength(10)]
        public string? ItemClassCode { get; set; }

        /// <summary>
        /// Item Class Name 
        /// </summary>
        [JsonPropertyName("itemClsNm")]
        [StringLength(200)]
        public string? ItemClassName { get; set; }

        /// <summary>
        /// Item Class Level
        /// </summary>
        [JsonPropertyName("itemClsLvl")]
        public long? ItemClassLevel { get; set; }

        /// <summary>
        /// Taxation Type Code
        /// </summary>
        [JsonPropertyName("taxTyCd")]
        [StringLength(5)]
        public string? TaxationTypeCode { get; set; }

        /// <summary>
        /// Whether it is Major Taget
        /// </summary>
        [JsonPropertyName("mjrTgYn")]
        [StringLength(1)]
        public string? MajorTagetYesNo { get; set; }

        /// <summary>
        /// Use Yes or No
        /// </summary>
        [JsonPropertyName("useYn")]
        [StringLength(1)]
        public string? UseYesNo { get; set; }
    }
}
