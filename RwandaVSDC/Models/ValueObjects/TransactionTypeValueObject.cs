using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    public class TransactionTypeValueObject: ValueObject<TransactionTypeValueObject>
    {
        private static readonly string CodeClassification = "14";
        private static readonly string CodeClassificationName = "Transaction Type";

        private const string CODE_NAME_C = "Copy";
        private const string CODE_NAME_N = "Normal";
        private const string CODE_NAME_P = "Proforma";
        private const string CODE_NAME_T = "Training";

        private const string CODE_DESCRIPTION_C = "Sales and purchase type : Copy";
        private const string CODE_DESCRIPTION_N = "Sales and purchase type : Normal";
        private const string CODE_DESCRIPTION_P = "Sales and purchase type : Proforma";
        private const string CODE_DESCRIPTION_T = "Sales and purchase type : Training";

        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        public static readonly TransactionTypeValueObject Copy = Create(TransactionType.Copy);
        public static readonly TransactionTypeValueObject Normal = Create(TransactionType.Normal);
        public static readonly TransactionTypeValueObject Proforma = Create(TransactionType.Proforma);
        public static readonly TransactionTypeValueObject Training = Create(TransactionType.Training);

        private TransactionTypeValueObject(string code, int sortOrder, string codeName, string codeDescription)
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

        public static TransactionTypeValueObject Create(TransactionType transactionType)
        {
            switch (transactionType)
            {
                case TransactionType.Copy:
                    return new TransactionTypeValueObject("C", (int)transactionType, CODE_NAME_C, CODE_DESCRIPTION_C);
                case TransactionType.Normal:
                    return new TransactionTypeValueObject("N", (int)transactionType, CODE_NAME_N, CODE_DESCRIPTION_N);
                case TransactionType.Proforma:
                    return new TransactionTypeValueObject("P", (int)transactionType, CODE_NAME_P, CODE_DESCRIPTION_P);
                case TransactionType.Training:
                    return new TransactionTypeValueObject("T", (int)transactionType, CODE_NAME_T, CODE_DESCRIPTION_T);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override bool EqualsCore(TransactionTypeValueObject other)
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
