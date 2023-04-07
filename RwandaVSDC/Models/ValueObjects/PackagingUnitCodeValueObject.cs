using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    internal class PackagingUnitCodeValueObject : ValueObject<PackagingUnitCodeValueObject>
    {
        public static readonly string CodeClassification = "17";
        public static readonly string CodeClassificationName = "Packaging Unit";

        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        private PackagingUnitCodeValueObject(string code, int sortOrder, string codeName, string codeDescription)
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

        public static PackagingUnitCodeValueObject Create(PackagingUnitCode packagingUnitCode)
        {
            switch (packagingUnitCode)
            {
                case PackagingUnitCode.AM:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Ampoule", "Ampoule");
                case PackagingUnitCode.BA:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Barrel", "Barrel");
                case PackagingUnitCode.BC:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Bottlecrate", "Bottlecrate");
                case PackagingUnitCode.BE:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Bundle", "Bundle");
                case PackagingUnitCode.BF:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Balloon, non-protected", "Balloon, non-protected");
                case PackagingUnitCode.BG:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Bag", "Bag");
                case PackagingUnitCode.BJ:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Bucket", "Bucket");
                case PackagingUnitCode.BK:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Basket", "Basket");
                case PackagingUnitCode.BL:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Bale", "Bale");
                case PackagingUnitCode.BQ:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Bottle, protected cylindrical", "Bottle, protected cylindrical");
                case PackagingUnitCode.BR:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Bar", "Bar");
                case PackagingUnitCode.BV:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Bottle, bulbous", "Bottle, bulbous");
                case PackagingUnitCode.BZ:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Bag", "Bag");
                case PackagingUnitCode.CA:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Can", "Can");
                case PackagingUnitCode.CH:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Chest", "Chest");
                case PackagingUnitCode.CJ:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Coffin", "Coffin");
                case PackagingUnitCode.CL:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Coil", "Coil");
                case PackagingUnitCode.CR:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Wooden Box, Wooden Case", "Wooden Box, Wooden Case");
                case PackagingUnitCode.CS:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Cassette", "Cassette");
                case PackagingUnitCode.CT:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Carton", "Carton");
                case PackagingUnitCode.CTN:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Container", "Container");
                case PackagingUnitCode.CY:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Cylinder", "Cylinder");
                case PackagingUnitCode.DR:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Drum", "Drum");
                case PackagingUnitCode.GT:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Extra Countable Item", "Extra Countable Item");
                case PackagingUnitCode.HH:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Hand Baggage", "Hand Baggage");
                case PackagingUnitCode.IZ:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Ingots", "Ingots");
                case PackagingUnitCode.JR:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Jar", "Jar");
                case PackagingUnitCode.JU:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Jug", "Jug");
                case PackagingUnitCode.JY:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Jerry CAN Cylindrical", "Jerry CAN Cylindrical");
                case PackagingUnitCode.KZ:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Canester", "Canester");
                case PackagingUnitCode.LZ:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Logs, in bundle/bunch/truss", "Logs, in bundle/bunch/truss");
                case PackagingUnitCode.NT:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Net", "Net");
                case PackagingUnitCode.OU:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Non-Exterior Packaging Unit", "Non-Exterior Packaging Unit");
                case PackagingUnitCode.PD:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Poddon", "Poddon");
                case PackagingUnitCode.PG:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Plate", "Plate");
                case PackagingUnitCode.PI:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Pipe", "Pipe");
                case PackagingUnitCode.PO:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Pilot", "Pilot");
                case PackagingUnitCode.PU:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Traypack", "Traypack");
                case PackagingUnitCode.RL:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Reel", "Reel");
                case PackagingUnitCode.RO:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Roll", "Roll");
                case PackagingUnitCode.RZ:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Rods, in bundle/bunch/truss", "Rods, in bundle/bunch/truss");
                case PackagingUnitCode.SK:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Skeletoncase", "Skeletoncase");
                case PackagingUnitCode.TY:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Tank, cylindrical", "Tank, cylindrical");
                case PackagingUnitCode.VG:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Bulk,gas(at 1031 mbar 15 oC)", "Bulk,gas(at 1031 mbar 15 oC)");
                case PackagingUnitCode.VL:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Bulk,liquid(at normal temperature/pressure)", "Bulk,liquid(at normal temperature/pressure)");
                case PackagingUnitCode.VO:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Bulk, solid, large particles(\"nodules\")", "Bulk, solid, large particles(\"nodules\")");
                case PackagingUnitCode.VQ:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Bulk, gas(liquefied at abnormal temperature/pressure)", "Bulk, gas(liquefied at abnormal temperature/pressure)");
                case PackagingUnitCode.VR:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Bulk, solid, granular particles(\"grains\")", "Bulk, solid, granular particles(\"grains\")");
                case PackagingUnitCode.VT:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Extra Bulk Item", "Extra Bulk Item");
                case PackagingUnitCode.VY:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Bulk, fine particles(\"powder\")", "Bulk, fine particles(\"powder\")");
                case PackagingUnitCode.ML:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "Mills", "cigarette Mills");
                case PackagingUnitCode.TN:
                    return new PackagingUnitCodeValueObject(packagingUnitCode.ToString(), (int)packagingUnitCode, "TAN", "1TAN REFER TO 20BAGS");
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override bool EqualsCore(PackagingUnitCodeValueObject other)
        {
            return _code == other._code &&
                   _sortOrder == other._sortOrder &&
                   _codeName == other._codeName &&
                   _codeDescription == other._codeDescription;
        }

        protected override int GetHashCodeCore()
        {
            return HashCode.Combine(_code, _sortOrder, _codeName, _codeDescription);
        }
    }
}
