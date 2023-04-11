using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Models.Enums
{
    public enum TransactionProgress
    {
        WaitForApproval = 1,
        Approved,
        CancelRequested,
        Canceled,
        Refunded,
        Transferred
    }
}
