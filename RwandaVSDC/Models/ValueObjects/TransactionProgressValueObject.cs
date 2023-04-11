using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    public class TransactionProgressValueObject : ValueObject<TransactionProgressValueObject>
    {
        private static readonly string CodeClassification = "11";
        private static readonly string CodeClassificationName = "Transaction Progress";

        private const string CODE_NAME_1 = "Wait for Approval";
        private const string CODE_NAME_2 = "Approved";
        private const string CODE_NAME_3 = "Cancel Requested";
        private const string CODE_NAME_4 = "Canceled";
        private const string CODE_NAME_5 = "Refunded";
        private const string CODE_NAME_6 = "Transferred ";

        private const string CODE_DESCRIPTION_1 = "Wait for Approval";
        private const string CODE_DESCRIPTION_2 = "Approved";
        private const string CODE_DESCRIPTION_3 = "Cancel Requested";
        private const string CODE_DESCRIPTION_4 = "Canceled";
        private const string CODE_DESCRIPTION_5 = "Refunded";
        private const string CODE_DESCRIPTION_6 = "Transferred ";

        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        public static readonly TransactionProgressValueObject WaitForApproval = Create(TransactionProgress.WaitForApproval);
        public static readonly TransactionProgressValueObject Approved = Create(TransactionProgress.Approved);
        public static readonly TransactionProgressValueObject CancelRequested = Create(TransactionProgress.CancelRequested);
        public static readonly TransactionProgressValueObject Canceled = Create(TransactionProgress.Canceled);
        public static readonly TransactionProgressValueObject Refunded = Create(TransactionProgress.Refunded);
        public static readonly TransactionProgressValueObject Transferred = Create(TransactionProgress.Transferred);

        private TransactionProgressValueObject(string code, int sortOrder, string codeName, string codeDescription)
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

        public static TransactionProgressValueObject Create(TransactionProgress transactionProgress)
        {
            switch (transactionProgress)
            {
                case TransactionProgress.WaitForApproval:
                    return new TransactionProgressValueObject("01", (int)transactionProgress, CODE_NAME_1, CODE_DESCRIPTION_1);
                case TransactionProgress.Approved:
                    return new TransactionProgressValueObject("02", (int)transactionProgress, CODE_NAME_2, CODE_DESCRIPTION_2);
                case TransactionProgress.CancelRequested:
                    return new TransactionProgressValueObject("03", (int)transactionProgress, CODE_NAME_3, CODE_DESCRIPTION_3);
                case TransactionProgress.Canceled:
                    return new TransactionProgressValueObject("04", (int)transactionProgress, CODE_NAME_4, CODE_DESCRIPTION_4);
                case TransactionProgress.Refunded:
                    return new TransactionProgressValueObject("05", (int)transactionProgress, CODE_NAME_5, CODE_DESCRIPTION_5);
                case TransactionProgress.Transferred:
                    return new TransactionProgressValueObject("06", (int)transactionProgress, CODE_NAME_6, CODE_DESCRIPTION_6);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override bool EqualsCore(TransactionProgressValueObject other)
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
