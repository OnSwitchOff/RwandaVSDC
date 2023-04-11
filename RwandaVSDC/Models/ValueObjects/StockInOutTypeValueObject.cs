using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    public class StockInOutTypeValueObject : ValueObject<StockInOutTypeValueObject>
    {
        private static readonly string CodeClassification = "12";
        private static readonly string CodeClassificationName = "Stock In/Out Type";

        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        private StockInOutTypeValueObject(string code, int sortOrder, string codeName, string codeDescription)
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

        public static StockInOutTypeValueObject Create(StockInOutType stockInOutType)
        {
            switch (stockInOutType)
            {
                case StockInOutType.ImportIn:
                    return new StockInOutTypeValueObject("01", 1, "Import", "Incoming-Import");
                case StockInOutType.PurchaseIn:
                    return new StockInOutTypeValueObject("02", 2, "Purchase", "Incoming-Purchase");
                case StockInOutType.ReturnIn:
                    return new StockInOutTypeValueObject("03", 3, "Return", "Incoming-Return");
                case StockInOutType.StockMovementIn:
                    return new StockInOutTypeValueObject("04", 4, "Stock Movement", "Incoming-Stock Movement");
                case StockInOutType.ProcessingIn:
                    return new StockInOutTypeValueObject("05", 5, "Processing", "Incoming-Processing");
                case StockInOutType.AdjustmentIn:
                    return new StockInOutTypeValueObject("06", 6, "Adjustment", "Incoming-Adjustment");
                case StockInOutType.SaleOut:
                    return new StockInOutTypeValueObject("11", 11, "Sale", "Outgoing-Sale");
                case StockInOutType.ReturnOut:
                    return new StockInOutTypeValueObject("12", 12, "Return", "Outgoing-Return");
                case StockInOutType.StockMovementOut:
                    return new StockInOutTypeValueObject("13", 13, "Stock Movement", "Outgoing-Stock Movement");
                case StockInOutType.ProcessingOut:
                    return new StockInOutTypeValueObject("14", 14, "Processing", "Outgoing-Processing");
                case StockInOutType.DiscardingOut:
                    return new StockInOutTypeValueObject("15", 15, "Discarding", "Outgoing-Discarding");
                case StockInOutType.AdjustmentOut:
                    return new StockInOutTypeValueObject("16", 16, "Adjustment", "Outgoing-Adjustment");
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override bool EqualsCore(StockInOutTypeValueObject other)
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
