using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    public class PurchaseReceiptTypeValueObject : ValueObject<PurchaseReceiptTypeValueObject>
    {
        private static readonly string CodeClassification = "38";
        private static readonly string CodeClassificationName = "Purchase Receipt Type";

        private const string CODE_NAME_P = "Purchase";
        private const string CODE_NAME_R = "Refund after Purchase";

        private const string CODE_DESCRIPTION_P = "Purchase";
        private const string CODE_DESCRIPTION_R = "Refund after Purchase";

        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        public static readonly PurchaseReceiptTypeValueObject Purchase = Create(PurchaseReceiptType.Purchase);
        public static readonly PurchaseReceiptTypeValueObject Refund = Create(PurchaseReceiptType.Refund);

        private PurchaseReceiptTypeValueObject(string code, int sortOrder, string codeName, string codeDescription)
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

        public static PurchaseReceiptTypeValueObject Create(PurchaseReceiptType purchaseReceiptType)
        {
            switch (purchaseReceiptType)
            {
                case PurchaseReceiptType.Purchase:
                    return new PurchaseReceiptTypeValueObject("P", (int)purchaseReceiptType, CODE_NAME_P, CODE_DESCRIPTION_P);
                case PurchaseReceiptType.Refund:
                    return new PurchaseReceiptTypeValueObject("R", (int)purchaseReceiptType, CODE_NAME_R, CODE_DESCRIPTION_R);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override bool EqualsCore(PurchaseReceiptTypeValueObject other)
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
