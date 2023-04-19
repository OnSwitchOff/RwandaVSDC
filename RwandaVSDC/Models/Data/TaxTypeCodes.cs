using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Data
{
    public static class TaxTypeCodes
    {
        public static string CodeClassification = "04";
        public static string CodeClassificationName = "Tax Type";
        public static IReadOnlyDictionary<TaxType, CodeInfo> Codes = InitDictionary();

        private static Dictionary<TaxType, CodeInfo> InitDictionary()
        {
            return new Dictionary<TaxType, CodeInfo>()
            {
                { TaxType.A, new CodeInfo("A", 1, "A-EX") },
                { TaxType.B, new CodeInfo("B", 2, "B-18.00%") },
                { TaxType.C, new CodeInfo("C", 3, "C") },
                { TaxType.D, new CodeInfo("D", 4, "D") }
            };
        }
    }
}
