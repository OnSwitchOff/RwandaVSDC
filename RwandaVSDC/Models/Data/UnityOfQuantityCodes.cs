using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Data
{
    public static class UnityOfQuantityCodes
    {
        public static string CodeClassification = "10";
        public static string CodeClassificationName = "Unit of Quantity";

        public static Dictionary<string, UnitOfQuantityCode> Codes = InitDictionary();

        private static Dictionary<string, UnitOfQuantityCode> InitDictionary()
        {
            return new Dictionary<string, UnitOfQuantityCode>()
            {
                { "4B", new UnitOfQuantityCode("4B", 1, "Pair","Pair") },
                { "AV", new UnitOfQuantityCode("AV", 2, "Cap", "Cap") },
                { "BA", new UnitOfQuantityCode("BA", 3, "Barrel", "Barrel") },
                { "BE", new UnitOfQuantityCode("BE", 4, "bundle", "bundle") },
                { "BG", new UnitOfQuantityCode("BG", 5, "bag", "bag") },
                { "BL", new UnitOfQuantityCode("BL", 6, "block","block") },
                { "BLL", new UnitOfQuantityCode("BLL", 7, "BLL Barrel", "BLL Barrel (petroleum) (158,987 dm3)") },
                { "BX", new UnitOfQuantityCode("BX", 8, "box", "box") },
                { "CEL", new UnitOfQuantityCode("CEL", 10, "Cell", "Cell") },
                { "CMT", new UnitOfQuantityCode("CMT", 11, "centimetre", "centimetre") },
                { "CR", new UnitOfQuantityCode("CR", 12, "CARAT","CARAT") },
                { "DR", new UnitOfQuantityCode("DR", 13, "Drum", "Drum") },
                { "DZ", new UnitOfQuantityCode("DZ", 14, "Dozen", "Dozen") },
                { "GLL", new UnitOfQuantityCode("GLL", 15, "Gallon", "Gallon") },
                { "GRM", new UnitOfQuantityCode("GRM", 16, "Gram", "Gram") },
                { "GRO", new UnitOfQuantityCode("GRO", 17, "Gross","Gross") },
                { "KG", new UnitOfQuantityCode("KG", 18, "Kilo-Gramme", "Kilo-Gramme") },
                { "KTM", new UnitOfQuantityCode("KTM", 19, "kilometre", "kilometre") },
                { "KWT", new UnitOfQuantityCode("KWT", 20, "kilowatt", "kilowatt") },
                { "L", new UnitOfQuantityCode("L", 21, "Litre", "Litre") },
                { "LBR", new UnitOfQuantityCode("LBR", 22, "pound","pound") },
                { "LK", new UnitOfQuantityCode("LK", 23, "link", "link") },
                { "LTR", new UnitOfQuantityCode("LTR", 24, "Litre", "Litre") },
                { "M", new UnitOfQuantityCode("M", 25, "Metre", "Metre") },
                { "M2", new UnitOfQuantityCode("M2", 26, "Square Metre", "Square Metre") },
                { "M3", new UnitOfQuantityCode("M3", 27, "Cubic Metre","Cubic Metre") },
                { "MGM", new UnitOfQuantityCode("MGM", 28, "milligram", "milligram") },
                { "MTR", new UnitOfQuantityCode("MTR", 29, "metre", "metre") },
                { "MWT", new UnitOfQuantityCode("MWT", 30, "megawatt hour (1000 kW.h)", "megawatt hour (1000 kW.h)") },
                { "NO", new UnitOfQuantityCode("NO", 31, "Number", "Number") },
                { "NX", new UnitOfQuantityCode("NX", 32, "part per thousand","part per thousand") },
                { "PA", new UnitOfQuantityCode("PA", 33, "packet", "packet") },
                { "PG", new UnitOfQuantityCode("PG", 34, "plate", "plate") },
                { "PR", new UnitOfQuantityCode("PR", 35, "pair", "pair") },
                { "RL", new UnitOfQuantityCode("RL", 36, "reel", "reel") },
                { "RO", new UnitOfQuantityCode("RO", 37, "roll","roll") },
                { "SET", new UnitOfQuantityCode("SET", 38, "set", "set") },
                { "ST", new UnitOfQuantityCode("ST", 39, "sheet", "sheet") },
                { "TNE", new UnitOfQuantityCode("TNE", 40, "tonne (metric ton)", "tonne (metric ton)") },
                { "TU", new UnitOfQuantityCode("TU", 41, "tube", "tube") },
                { "U", new UnitOfQuantityCode("U", 42, "Pieces/item [Number]","Pieces/item [Number]") },
                { "YRD", new UnitOfQuantityCode("YRD", 43, "yard", "yard") }             
            };
        }
    }

    public class UnitOfQuantityCode
    {
        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        public UnitOfQuantityCode(string code, int sortOrder, string codeName, string codeDescription)
        {
            _code = code;
            _sortOrder = sortOrder;
            _codeName = codeName;
            _codeDescription = codeDescription;
        }

        public string Code => _code;
        public int SortOrder => _sortOrder;
        public string CodeName => _codeName;
        public string CodeDescription => _codeDescription;
    }
}
