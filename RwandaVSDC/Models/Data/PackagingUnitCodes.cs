using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Data
{
    public static class PackagingUnitCodes
    {
        public static string CodeClassification = "17";
        public static string CodeClassificationName = "Packaging Unit";
        public static IReadOnlyDictionary<PackagingUnitCode, CodeInfo> Codes = InitDictionary();
        private static Dictionary<PackagingUnitCode, CodeInfo> InitDictionary()
        {
            return new Dictionary<PackagingUnitCode, CodeInfo>()
            {
                { PackagingUnitCode.AM, new CodeInfo(PackagingUnitCode.AM.ToString(), (int)PackagingUnitCode.AM, "Ampoule", "Ampoule") },
                { PackagingUnitCode.BA, new CodeInfo(PackagingUnitCode.BA.ToString(), (int)PackagingUnitCode.BA, "Barrel", "Barrel") },
                { PackagingUnitCode.BC, new CodeInfo(PackagingUnitCode.BC.ToString(), (int)PackagingUnitCode.BC, "Bottlecrate", "Bottlecrate") },
                { PackagingUnitCode.BE, new CodeInfo(PackagingUnitCode.BE.ToString(), (int)PackagingUnitCode.BE, "Bundle", "Bundle") },
                { PackagingUnitCode.BF, new CodeInfo(PackagingUnitCode.BF.ToString(), (int)PackagingUnitCode.BF, "Balloon, non-protected", "Balloon, non-protected") },
                { PackagingUnitCode.BG, new CodeInfo(PackagingUnitCode.BG.ToString(), (int)PackagingUnitCode.BG, "Bag", "Bag") },
                { PackagingUnitCode.BJ, new CodeInfo(PackagingUnitCode.BJ.ToString(), (int)PackagingUnitCode.BJ, "Bucket", "Bucket") },
                { PackagingUnitCode.BK, new CodeInfo(PackagingUnitCode.BK.ToString(), (int)PackagingUnitCode.BK, "Basket", "Basket") },
                { PackagingUnitCode.BL, new CodeInfo(PackagingUnitCode.BL.ToString(), (int)PackagingUnitCode.BL, "Bale", "Bale") },
                { PackagingUnitCode.BQ, new CodeInfo(PackagingUnitCode.BQ.ToString(), (int)PackagingUnitCode.BQ, "Bottle, protected cylindrical", "Bottle, protected cylindrical") },
                { PackagingUnitCode.BR, new CodeInfo(PackagingUnitCode.BR.ToString(), (int)PackagingUnitCode.BR, "Bar", "Bar") },
                { PackagingUnitCode.BV, new CodeInfo(PackagingUnitCode.BV.ToString(), (int)PackagingUnitCode.BV, "Bottle, bulbous", "Bottle, bulbous") },
                { PackagingUnitCode.BZ, new CodeInfo(PackagingUnitCode.BZ.ToString(), (int)PackagingUnitCode.BZ, "Bag", "Bag") },
                { PackagingUnitCode.CA, new CodeInfo(PackagingUnitCode.CA.ToString(), (int)PackagingUnitCode.CA, "Can", "Can") },
                { PackagingUnitCode.CH, new CodeInfo(PackagingUnitCode.CH.ToString(), (int)PackagingUnitCode.CH, "Chest", "Chest") },
                { PackagingUnitCode.CJ, new CodeInfo(PackagingUnitCode.CJ.ToString(), (int)PackagingUnitCode.CJ, "Coffin", "Coffin") },
                { PackagingUnitCode.CL, new CodeInfo(PackagingUnitCode.CL.ToString(), (int)PackagingUnitCode.CL, "Coil", "Coil") },
                { PackagingUnitCode.CR, new CodeInfo(PackagingUnitCode.CR.ToString(), (int)PackagingUnitCode.CR, "Wooden Box, Wooden Case", "Wooden Box, Wooden Case") },
                { PackagingUnitCode.CS, new CodeInfo(PackagingUnitCode.CS.ToString(), (int)PackagingUnitCode.CS, "Cassette", "Cassette") },
                { PackagingUnitCode.CT, new CodeInfo(PackagingUnitCode.CT.ToString(), (int)PackagingUnitCode.CT, "Carton", "Carton") },
                { PackagingUnitCode.CTN, new CodeInfo(PackagingUnitCode.CTN.ToString(), (int)PackagingUnitCode.CTN, "Container", "Container") },
                { PackagingUnitCode.CY, new CodeInfo(PackagingUnitCode.CY.ToString(), (int)PackagingUnitCode.CY, "Cylinder", "Cylinder") },
                { PackagingUnitCode.DR, new CodeInfo(PackagingUnitCode.DR.ToString(), (int)PackagingUnitCode.DR, "Drum", "Drum") },
                { PackagingUnitCode.GT, new CodeInfo(PackagingUnitCode.GT.ToString(), (int)PackagingUnitCode.GT, "Extra Countable Item", "Extra Countable Item") },
                { PackagingUnitCode.HH, new CodeInfo(PackagingUnitCode.HH.ToString(), (int)PackagingUnitCode.HH, "Hand Baggage", "Hand Baggage") },
                { PackagingUnitCode.IZ, new CodeInfo(PackagingUnitCode.IZ.ToString(), (int)PackagingUnitCode.IZ, "Ingots", "Ingots") },
                { PackagingUnitCode.JR, new CodeInfo(PackagingUnitCode.JR.ToString(), (int)PackagingUnitCode.JR, "Jar", "Jar") },
                { PackagingUnitCode.JU, new CodeInfo(PackagingUnitCode.JU.ToString(), (int)PackagingUnitCode.JU, "Jug", "Jug") },
                { PackagingUnitCode.JY, new CodeInfo(PackagingUnitCode.JY.ToString(), (int)PackagingUnitCode.JY, "Jerry CAN Cylindrical", "Jerry CAN Cylindrical") },
                { PackagingUnitCode.KZ, new CodeInfo(PackagingUnitCode.KZ.ToString(), (int)PackagingUnitCode.KZ, "Canester", "Canester") },
                { PackagingUnitCode.LZ, new CodeInfo(PackagingUnitCode.LZ.ToString(), (int)PackagingUnitCode.LZ, "Logs, in bundle/bunch/truss", "Logs, in bundle/bunch/truss") },
                { PackagingUnitCode.NT, new CodeInfo(PackagingUnitCode.NT.ToString(), (int)PackagingUnitCode.NT, "Net", "Net") },
                { PackagingUnitCode.OU, new CodeInfo(PackagingUnitCode.OU.ToString(), (int)PackagingUnitCode.OU, "Non-Exterior Packaging Unit", "Non-Exterior Packaging Unit") },
                { PackagingUnitCode.PD, new CodeInfo(PackagingUnitCode.PD.ToString(), (int)PackagingUnitCode.PD, "Poddon", "Poddon") },
                { PackagingUnitCode.PG, new CodeInfo(PackagingUnitCode.PG.ToString(), (int)PackagingUnitCode.PG, "Plate", "Plate") },
                { PackagingUnitCode.PI, new CodeInfo(PackagingUnitCode.PI.ToString(), (int)PackagingUnitCode.PI, "Pipe", "Pipe") },
                { PackagingUnitCode.PO, new CodeInfo(PackagingUnitCode.PO.ToString(), (int)PackagingUnitCode.PO, "Pilot", "Pilot") },
                { PackagingUnitCode.PU, new CodeInfo(PackagingUnitCode.PU.ToString(), (int)PackagingUnitCode.PU, "Traypack", "Traypack") },
                { PackagingUnitCode.RL, new CodeInfo(PackagingUnitCode.RL.ToString(), (int)PackagingUnitCode.RL, "Reel", "Reel") },
                { PackagingUnitCode.RO, new CodeInfo(PackagingUnitCode.RO.ToString(), (int)PackagingUnitCode.RO, "Roll", "Roll") },
                { PackagingUnitCode.RZ, new CodeInfo(PackagingUnitCode.RZ.ToString(), (int)PackagingUnitCode.RZ, "Rods, in bundle/bunch/truss", "Rods, in bundle/bunch/truss") },
                { PackagingUnitCode.SK, new CodeInfo(PackagingUnitCode.SK.ToString(), (int)PackagingUnitCode.SK, "Skeletoncase", "Skeletoncase") },
                { PackagingUnitCode.TY, new CodeInfo(PackagingUnitCode.TY.ToString(), (int)PackagingUnitCode.TY, "Tank, cylindrical", "Tank, cylindrical") },
                { PackagingUnitCode.VG, new CodeInfo(PackagingUnitCode.VG.ToString(), (int)PackagingUnitCode.VG, "Bulk,gas(at 1031 mbar 15 oC)", "Bulk,gas(at 1031 mbar 15 oC)") },
                { PackagingUnitCode.VL, new CodeInfo(PackagingUnitCode.VL.ToString(), (int)PackagingUnitCode.VL, "Bulk,liquid(at normal temperature/pressure)", "Bulk,liquid(at normal temperature/pressure)") },
                { PackagingUnitCode.VO, new CodeInfo(PackagingUnitCode.VO.ToString(), (int)PackagingUnitCode.VO, "Bulk, solid, large particles(\"nodules\")", "Bulk, solid, large particles(\"nodules\")") },
                { PackagingUnitCode.VQ, new CodeInfo(PackagingUnitCode.VQ.ToString(), (int)PackagingUnitCode.VQ, "Bulk, gas(liquefied at abnormal temperature/pressure)", "Bulk, gas(liquefied at abnormal temperature/pressure)") },
                { PackagingUnitCode.VR, new CodeInfo(PackagingUnitCode.VR.ToString(), (int)PackagingUnitCode.VR, "Bulk, solid, granular particles(\"grains\")", "Bulk, solid, granular particles(\"grains\")") },
                { PackagingUnitCode.VT, new CodeInfo(PackagingUnitCode.VT.ToString(), (int)PackagingUnitCode.VT, "Extra Bulk Item", "Extra Bulk Item") },
                { PackagingUnitCode.VY, new CodeInfo(PackagingUnitCode.VY.ToString(), (int)PackagingUnitCode.VY, "Bulk, fine particles(\"powder\")", "Bulk, fine particles(\"powder\")") },
                { PackagingUnitCode.ML, new CodeInfo(PackagingUnitCode.ML.ToString(), (int)PackagingUnitCode.ML, "Mills", "cigarette Mills") },
                { PackagingUnitCode.TN, new CodeInfo(PackagingUnitCode.TN.ToString(), (int)PackagingUnitCode.TN, "TAN", "1TAN REFER TO 20BAGS") },
            };
        }
    }
}
