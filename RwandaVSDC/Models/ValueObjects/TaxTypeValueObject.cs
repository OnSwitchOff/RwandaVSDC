using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    public class TaxTypeValueObject : ValueObject<TaxTypeValueObject>
    {
        private static readonly string CodeClassification = "04";
        private static readonly string CodeClassificationName = "Tax Type";

        private const string CODE_NAME_A = "A-EX";
        private const string CODE_NAME_B = "B-18.00%";
        private const string CODE_NAME_C = "C";
        private const string CODE_NAME_D = "D";

        private const string CODE_DESCRIPTION_A = "A-EX";
        private const string CODE_DESCRIPTION_B = "B-18.00%";
        private const string CODE_DESCRIPTION_C = "C";
        private const string CODE_DESCRIPTION_D = "D";

        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        public static readonly TaxTypeValueObject A = Create(TaxType.A);
        public static readonly TaxTypeValueObject B = Create(TaxType.B);
        public static readonly TaxTypeValueObject C = Create(TaxType.C);
        public static readonly TaxTypeValueObject D = Create(TaxType.D);

        private TaxTypeValueObject(string code, int sortOrder, string codeName, string codeDescription)
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

        public static TaxTypeValueObject Create(TaxType taxType)
        {
            switch (taxType)
            {
                case TaxType.A:
                    return new TaxTypeValueObject(taxType.ToString(), (int)taxType, CODE_NAME_A, CODE_DESCRIPTION_A);
                case TaxType.B:
                    return new TaxTypeValueObject(taxType.ToString(), (int)taxType, CODE_NAME_B, CODE_DESCRIPTION_B);
                case TaxType.C:
                    return new TaxTypeValueObject(taxType.ToString(), (int)taxType, CODE_NAME_C, CODE_DESCRIPTION_C);
                case TaxType.D:
                    return new TaxTypeValueObject(taxType.ToString(), (int)taxType, CODE_NAME_D, CODE_DESCRIPTION_D);
                default:
                    throw new ArgumentException();
            }            
        }

        protected override bool EqualsCore(TaxTypeValueObject other)
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
