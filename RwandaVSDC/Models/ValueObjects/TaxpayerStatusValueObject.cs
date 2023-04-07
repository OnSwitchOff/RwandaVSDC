using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    public class TaxpayerStatusValueObject: ValueObject<TaxpayerStatusValueObject>
    {
        private static readonly string CodeClassification = "15";
        private static readonly string CodeClassificationName = "Taxpayer Status";

        private const string CODE_NAME_A = "Active";
        private const string CODE_NAME_D = "Discard";

        private const string CODE_DESCRIPTION_A = "Active";
        private const string CODE_DESCRIPTION_D = "Discard";

        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        public static readonly TaxpayerStatusValueObject A = Create(TaxpayerStatus.A);
        public static readonly TaxpayerStatusValueObject D = Create(TaxpayerStatus.D);

        private TaxpayerStatusValueObject(string code, int sortOrder, string codeName, string codeDescription)
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

        public static TaxpayerStatusValueObject Create(TaxpayerStatus taxpayerStatus)
        {
            switch (taxpayerStatus)
            {
                case TaxpayerStatus.A:
                    return new TaxpayerStatusValueObject(taxpayerStatus.ToString(), (int)taxpayerStatus, CODE_NAME_A, CODE_DESCRIPTION_A);
                case TaxpayerStatus.D:
                    return new TaxpayerStatusValueObject(taxpayerStatus.ToString(), (int)taxpayerStatus, CODE_NAME_D, CODE_DESCRIPTION_D);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override bool EqualsCore(TaxpayerStatusValueObject other)
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
