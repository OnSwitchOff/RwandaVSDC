using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    public class SalesReceiptTypeValueObject : ValueObject<SalesReceiptTypeValueObject>
    {
        private static readonly string CodeClassification = "37";
        private static readonly string CodeClassificationName = "Sales Receipt Type";

        private const string CODE_NAME_S = "Sale";
        private const string CODE_NAME_R = "Refund after Sale";

        private const string CODE_DESCRIPTION_S = "Sale";
        private const string CODE_DESCRIPTION_R = "Refund after Sale";

        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        public static readonly SalesReceiptTypeValueObject Copy = Create(SalesReceiptType.Sale);
        public static readonly SalesReceiptTypeValueObject Normal = Create(SalesReceiptType.Refund);

        private SalesReceiptTypeValueObject(string code, int sortOrder, string codeName, string codeDescription)
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

        public static SalesReceiptTypeValueObject Create(SalesReceiptType salesReceiptType)
        {
            switch (salesReceiptType)
            {
                case SalesReceiptType.Sale:
                    return new SalesReceiptTypeValueObject("S", (int)salesReceiptType, CODE_NAME_S, CODE_DESCRIPTION_S);
                case SalesReceiptType.Refund:
                    return new SalesReceiptTypeValueObject("R", (int)salesReceiptType, CODE_NAME_R, CODE_DESCRIPTION_R);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override bool EqualsCore(SalesReceiptTypeValueObject other)
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

