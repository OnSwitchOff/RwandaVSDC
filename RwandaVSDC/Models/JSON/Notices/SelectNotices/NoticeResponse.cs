using RwandaVSDC.Models.JSON.Branches.SelectBranches;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.JSON.Notices.SelectNotices
{
    /// <summary>
    /// Search Notice Response
    /// </summary>
    public class NoticeResponse
    {/// <summary>
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
        public NoticeResponseData? Data { get; set; }
    }

    public class NoticeResponseData
    {
        /// <summary>
        /// Notice Information list
        /// </summary>
        [JsonPropertyName("noticeList")]
        public List<NoticeInformation>? NoticeList { get; set; }
    }

    /// <summary>
    /// Notice Information
    /// </summary>
    public class NoticeInformation
    {
        /// <summary>
        /// Notice Number
        /// </summary>
        [JsonPropertyName("noticeNo")]
        public ulong? NoticeNumber { get; set; }


        /// <summary>
        /// Title
        /// </summary>
        [JsonPropertyName("title")]
        [StringLength(1000)]
        public string? Title { get; set; }

        /// <summary>
        /// Content
        /// </summary>
        [JsonPropertyName("cont")]
        [StringLength(4000)]
        public string? Content { get; set; }

        /// <summary>
        /// Detail URL
        /// </summary>
        [JsonPropertyName("dtlUrl")]
        [StringLength(200)]
        public string? DetailURL { get; set; }

        /// <summary>
        /// Registration name
        /// </summary>
        [JsonPropertyName("regrNm")]
        [StringLength(60)]
        public string? RegistrationName { get; set; }

        /// <summary>
        /// Registration date time
        /// </summary>
        [JsonPropertyName("regDt")]
        [StringLength(14)]
        public string? RegistrationDateTime { get; set; }
    }

}
