using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    public class RefundReasonCodeValueObject : ValueObject<RefundReasonCodeValueObject>
    {
        private static readonly string CodeClassification = "32";
        private static readonly string CodeClassificationName = "Refund reason code";

        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        private RefundReasonCodeValueObject(string code, int sortOrder, string codeName, string codeDescription)
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

        public static RefundReasonCodeValueObject Create(RefundReasonCode refundReasonCode)
        {
            switch (refundReasonCode)
            {
                case RefundReasonCode.MissingQuantity:
                    return new RefundReasonCodeValueObject("01", 1, "Missing Quantity", "Missing Quantity");
                case RefundReasonCode.MissingItem:
                    return new RefundReasonCodeValueObject("02", 2, "Missing Item", "Missing Item");
                case RefundReasonCode.Damaged:
                    return new RefundReasonCodeValueObject("03", 3, "Damaged", "Damaged");
                case RefundReasonCode.Wasted:
                    return new RefundReasonCodeValueObject("04", 4, "Wasted", "Wasted");
                case RefundReasonCode.RawMaterialShortage:
                    return new RefundReasonCodeValueObject("05", 5, "Raw Material Shortage", "Raw Material Shortage");
                case RefundReasonCode.Refund:
                    return new RefundReasonCodeValueObject("06", 6, "Refund", "Refund");
                case RefundReasonCode.WrongCustomerTin:
                    return new RefundReasonCodeValueObject("07", 7, "Wrong Customer TIN", "Wrong Customer TIN");
                case RefundReasonCode.WrongCustomerName:
                    return new RefundReasonCodeValueObject("08", 8, "Wrong Customer name", "Wrong Customer name");
                case RefundReasonCode.WrongAmountPrice:
                    return new RefundReasonCodeValueObject("09", 9, "Wrong Amount/price", "Wrong Amount/price");
                case RefundReasonCode.WrongQuantity:
                    return new RefundReasonCodeValueObject("10", 10, "Wrong Quantity", "Wrong Quantity");
                case RefundReasonCode.WrongItems:
                    return new RefundReasonCodeValueObject("11", 11, "Wrong Item(s)", "Wrong Item(s)");
                case RefundReasonCode.WrongTaxType:
                    return new RefundReasonCodeValueObject("12", 12, "Wrong tax type", "Wrong tax type");
                case RefundReasonCode.OtherReason:
                    return new RefundReasonCodeValueObject("13", 13, "Other reason", "Other reason");
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override bool EqualsCore(RefundReasonCodeValueObject other)
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
