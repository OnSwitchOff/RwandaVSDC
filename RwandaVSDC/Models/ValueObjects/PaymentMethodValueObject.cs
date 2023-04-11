using RwandaVSDC.Models.Common;
using RwandaVSDC.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.ValueObjects
{
    public class PaymentMethodValueObject : ValueObject<PaymentMethodValueObject>
    {
        private static readonly string CodeClassification = "07";
        private static readonly string CodeClassificationName = "Payment Method";

        private const string CODE_NAME_1 = "CASH";
        private const string CODE_NAME_2 = "CREDIT";
        private const string CODE_NAME_3 = "CASH/CREDIT";
        private const string CODE_NAME_4 = "BANK CHECK";
        private const string CODE_NAME_5 = "DEBIT&CREDIT CARD";
        private const string CODE_NAME_6 = "MOBILE MONEY";
        private const string CODE_NAME_7 = "OTHER";

        private const string CODE_DESCRIPTION_1 = "CASH";
        private const string CODE_DESCRIPTION_2 = "CREDIT";
        private const string CODE_DESCRIPTION_3 = "CASH/CREDIT";
        private const string CODE_DESCRIPTION_4 = "BANK CHECK";
        private const string CODE_DESCRIPTION_5 = "PAYMENT USING CARD";
        private const string CODE_DESCRIPTION_6 = "ANY TRANSACTION USING MOBILE MONEY SYSTEM";
        private const string CODE_DESCRIPTION_7 = "OTHER MEANS OF PAYMENT";

        private readonly string _code;
        private readonly int _sortOrder;
        private readonly string _codeName;
        private readonly string _codeDescription;

        public static readonly PaymentMethodValueObject Cash = Create(PaymentMethod.Cash);
        public static readonly PaymentMethodValueObject Credit = Create(PaymentMethod.Credit);
        public static readonly PaymentMethodValueObject CashCredit = Create(PaymentMethod.CashCredit);
        public static readonly PaymentMethodValueObject BankCheck = Create(PaymentMethod.BankCheck);
        public static readonly PaymentMethodValueObject DebitCreditCard = Create(PaymentMethod.DebitCreditCard);
        public static readonly PaymentMethodValueObject MobileMoney = Create(PaymentMethod.MobileMoney);
        public static readonly PaymentMethodValueObject Other = Create(PaymentMethod.Other);

        private PaymentMethodValueObject(string code, int sortOrder, string codeName, string codeDescription)
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

        public static PaymentMethodValueObject Create(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.Cash:
                    return new PaymentMethodValueObject("01", (int)paymentMethod, CODE_NAME_1, CODE_DESCRIPTION_1);
                case PaymentMethod.Credit:
                    return new PaymentMethodValueObject("02", (int)paymentMethod, CODE_NAME_2, CODE_DESCRIPTION_2);
                case PaymentMethod.CashCredit:
                    return new PaymentMethodValueObject("03", (int)paymentMethod, CODE_NAME_3, CODE_DESCRIPTION_3);
                case PaymentMethod.BankCheck:
                    return new PaymentMethodValueObject("04", (int)paymentMethod, CODE_NAME_4, CODE_DESCRIPTION_4);
                case PaymentMethod.DebitCreditCard:
                    return new PaymentMethodValueObject("05", (int)paymentMethod, CODE_NAME_5, CODE_DESCRIPTION_5);
                case PaymentMethod.MobileMoney:
                    return new PaymentMethodValueObject("06", (int)paymentMethod, CODE_NAME_6, CODE_DESCRIPTION_6);
                case PaymentMethod.Other:
                    return new PaymentMethodValueObject("07", (int)paymentMethod, CODE_NAME_7, CODE_DESCRIPTION_7);
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override bool EqualsCore(PaymentMethodValueObject other)
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
