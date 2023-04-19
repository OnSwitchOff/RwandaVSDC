using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Data
{
    public static class ProductTypeCodes
    {
        public static string CodeClassification = "24";
        public static string CodeClassificationName = "Product Type";
        public static IReadOnlyDictionary<ProductType, CodeInfo> Codes = InitDictionary();

        private static Dictionary<ProductType, CodeInfo> InitDictionary()
        {
            return new Dictionary<ProductType, CodeInfo>()
            {
                { ProductType.RawMaterial, new CodeInfo("1", 1, "Raw Material", "Raw Material") },
                { ProductType.FinishedProduct, new CodeInfo("2", 2, "Finished Product", "Finished Product") },
                { ProductType.Service, new CodeInfo("3", 3, "Service", "Service without stock") }
            };
        }
    }
}
