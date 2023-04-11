using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Enums
{
    public enum RefundReasonCode
    {
        MissingQuantity = 1,
        MissingItem,
        Damaged,
        Wasted,
        RawMaterialShortage,
        Refund,
        WrongCustomerTin,
        WrongCustomerName,
        WrongAmountPrice,
        WrongQuantity,
        WrongItems,
        WrongTaxType,
        OtherReason,
    }
}
