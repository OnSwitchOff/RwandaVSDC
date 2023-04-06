using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Code.SelectCodes
{
    /// <summary>
    /// Search code Response
    /// </summary>
    public class CodeResponse
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
        public CodeResponseData? Data { get; set; }
    }


    public class CodeResponseData
    {
        /// <summary>
        /// Code classification information list
        /// </summary>
        [JsonPropertyName("clsList")]
        public List<CodeClassificationInformation>? ClsList { get; set; }
    }

    /// <summary>
    /// Code classification information
    /// </summary>
    public class CodeClassificationInformation
    {
        /// <summary>
        /// Code Class 
        /// </summary>
        [JsonPropertyName("cdCls")]
        [StringLength(2)]
        public string? CodeClass  { get; set; }

        /// <summary>
        /// Code Class Name 
        /// </summary>
        [JsonPropertyName("cdClsNm")]
        [StringLength(60)]
        public string? CodeClassName { get; set; }

        /// <summary>
        /// Code Class Description
        /// </summary>
        [JsonPropertyName("cdClsDesc")]
        [StringLength(500)]
        public string? CodeClassDescription { get; set; }

        /// <summary>
        /// Use Yes or No
        /// </summary>
        [JsonPropertyName("useYn")]
        [StringLength(1)]
        public string? UseYesNo { get; set; }

        /// <summary>
        /// User Define Name 1
        /// </summary>
        [JsonPropertyName("userDfnNm1")]
        [StringLength(60)]
        public string? UserDefineName1 { get; set; }

        /// <summary>
        /// User Define Name 2
        /// </summary>
        [JsonPropertyName("userDfnNm2")]
        [StringLength(60)]
        public string? UserDefineName2 { get; set; }

        /// <summary>
        /// User Define Name 3
        /// </summary>
        [JsonPropertyName("userDfnNm3")]
        [StringLength(60)]
        public string? UserDefineName3 { get; set; }

        /// <summary>
        /// Code Details information List 
        /// </summary>
        [JsonPropertyName("dtlList")]
        public List<CodeDetailsInformation>? CodeDetailsInformationList { get; set; }
    }


    /// <summary>
    /// Code Details information
    /// </summary>
    public class CodeDetailsInformation
    {
        /// <summary>
        /// Code 
        /// </summary>
        [JsonPropertyName("cd")]
        [StringLength(5)]
        public string? Code { get; set; }

        /// <summary>
        /// Code Name
        /// </summary>
        [JsonPropertyName("cdNm")]
        [StringLength(60)]
        public string? CodeName { get; set; }

        /// <summary>
        /// Code Description
        /// </summary>
        [JsonPropertyName("cdDesc")]
        [StringLength(500)]
        public string? CodeDescription { get; set; }

        /// <summary>
        /// Use Yes or No
        /// </summary>
        [JsonPropertyName("useYn")]
        [StringLength(1)]
        public string? UseYesNo { get; set; }

        /// <summary>
        /// Sort Order
        /// </summary>
        [JsonPropertyName("srtOrd")]
        public int SortOrder { get; set; }

        /// <summary>
        /// User Define Code 1
        /// </summary>
        [JsonPropertyName("userDfnCd1")]
        [StringLength(20)]
        public string? UserDefineCode1 { get; set; }

        /// <summary>
        /// User Define Code 2
        /// </summary>
        [JsonPropertyName("userDfnCd2")]
        [StringLength(20)]
        public string? UserDefineCode2 { get; set; }

        /// <summary>
        /// User Define Code 3
        /// </summary>
        [JsonPropertyName("userDfnCd3")]
        [StringLength(20)]
        public string? UserDefineCode3 { get; set; }
    }
}
