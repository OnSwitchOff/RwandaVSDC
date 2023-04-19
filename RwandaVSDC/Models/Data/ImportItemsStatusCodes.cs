using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Data
{
    public static class ImportItemsStatusCodes
    {
        public static string CodeClassification = "26";
        public static string CodeClassificationName = "Import item Status";
        public static IReadOnlyDictionary<ImportItemStatus, CodeInfo> Codes = InitDictionary();

        private static Dictionary<ImportItemStatus, CodeInfo> InitDictionary()
        {
            return new Dictionary<ImportItemStatus, CodeInfo>()
            {
                { ImportItemStatus.Unsent, new CodeInfo("1", 1, "Unsent", "") },
                { ImportItemStatus.Waiting, new CodeInfo("2", 2, "Waiting", "") },
                { ImportItemStatus.Approved, new CodeInfo("3", 3, "Approved", "") },
                { ImportItemStatus.Cancelled, new CodeInfo("4", 4, "Cancelled", "") }
            };
        }
    }
}
