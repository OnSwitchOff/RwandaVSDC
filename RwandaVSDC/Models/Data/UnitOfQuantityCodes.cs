using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Data
{
    public static class UnitOfQuantityCodes
    {
        public static string CodeClassification = "10";
        public static string CodeClassificationName = "Unit of Quantity";
        public static IReadOnlyDictionary<string, CodeInfo> Codes = InitDictionary();
        private static Dictionary<string, CodeInfo> InitDictionary()
        {
            return new Dictionary<string, CodeInfo>()
            {
                { "4B", new CodeInfo("4B", 1, "Pair","Pair") },
                { "AV", new CodeInfo("AV", 2, "Cap", "Cap") },
                { "BA", new CodeInfo("BA", 3, "Barrel", "Barrel") },
                { "BE", new CodeInfo("BE", 4, "bundle", "bundle") },
                { "BG", new CodeInfo("BG", 5, "bag", "bag") },
                { "BL", new CodeInfo("BL", 6, "block","block") },
                { "BLL", new CodeInfo("BLL", 7, "BLL Barrel", "BLL Barrel (petroleum) (158,987 dm3)") },
                { "BX", new CodeInfo("BX", 8, "box", "box") },
                { "CA", new CodeInfo("CA", 9, "Can", "Can") },
                { "CEL", new CodeInfo("CEL", 10, "Cell", "Cell") },
                { "CMT", new CodeInfo("CMT", 11, "centimetre", "centimetre") },
                { "CR", new CodeInfo("CR", 12, "CARAT","CARAT") },
                { "DR", new CodeInfo("DR", 13, "Drum", "Drum") },
                { "DZ", new CodeInfo("DZ", 14, "Dozen", "Dozen") },
                { "GLL", new CodeInfo("GLL", 15, "Gallon", "Gallon") },
                { "GRM", new CodeInfo("GRM", 16, "Gram", "Gram") },
                { "GRO", new CodeInfo("GRO", 17, "Gross","Gross") },
                { "KG", new CodeInfo("KG", 18, "Kilo-Gramme", "Kilo-Gramme") },
                { "KTM", new CodeInfo("KTM", 19, "kilometre", "kilometre") },
                { "KWT", new CodeInfo("KWT", 20, "kilowatt", "kilowatt") },
                { "L", new CodeInfo("L", 21, "Litre", "Litre") },
                { "LBR", new CodeInfo("LBR", 22, "pound","pound") },
                { "LK", new CodeInfo("LK", 23, "link", "link") },
                { "LTR", new CodeInfo("LTR", 24, "Litre", "Litre") },
                { "M", new CodeInfo("M", 25, "Metre", "Metre") },
                { "M2", new CodeInfo("M2", 26, "Square Metre", "Square Metre") },
                { "M3", new CodeInfo("M3", 27, "Cubic Metre","Cubic Metre") },
                { "MGM", new CodeInfo("MGM", 28, "milligram", "milligram") },
                { "MTR", new CodeInfo("MTR", 29, "metre", "metre") },
                { "MWT", new CodeInfo("MWT", 30, "megawatt hour (1000 kW.h)", "megawatt hour (1000 kW.h)") },
                { "NO", new CodeInfo("NO", 31, "Number", "Number") },
                { "NX", new CodeInfo("NX", 32, "part per thousand","part per thousand") },
                { "PA", new CodeInfo("PA", 33, "packet", "packet") },
                { "PG", new CodeInfo("PG", 34, "plate", "plate") },
                { "PR", new CodeInfo("PR", 35, "pair", "pair") },
                { "RL", new CodeInfo("RL", 36, "reel", "reel") },
                { "RO", new CodeInfo("RO", 37, "roll","roll") },
                { "SET", new CodeInfo("SET", 38, "set", "set") },
                { "ST", new CodeInfo("ST", 39, "sheet", "sheet") },
                { "TNE", new CodeInfo("TNE", 40, "tonne (metric ton)", "tonne (metric ton)") },
                { "TU", new CodeInfo("TU", 41, "tube", "tube") },
                { "U", new CodeInfo("U", 42, "Pieces/item [Number]","Pieces/item [Number]") },
                { "YRD", new CodeInfo("YRD", 43, "yard", "yard") }             
            };
        }
    }
}
