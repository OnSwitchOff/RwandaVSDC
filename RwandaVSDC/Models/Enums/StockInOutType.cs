using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Enums
{
    public enum StockInOutType
    {
        ImportIn = 1,
        PurchaseIn,
        ReturnIn,
        StockMovementIn,
        ProcessingIn,
        AdjustmentIn,
        SaleOut = 11,
        ReturnOut,
        StockMovementOut,
        ProcessingOut,
        DiscardingOut,
        AdjustmentOut
    }
}
