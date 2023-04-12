using RwandaVSDC.Models.JSON.TransactionsPurchase.SavePurchases;
using RwandaVSDC.Models.JSON.TransactionsPurchase.SelectTransactionsPurchaseSales;

namespace RwandaVSDC.Services.ApiClients.TransactionsPurchaseApiClient
{
    public interface ITransactionsPurchaseApiClient
    {
        /// <summary>
        /// Lookup purchases-sales transaction list.
        /// You can look up sales infomation in order to regiser purchases on taxpayer's branch registered in server.
        /// This API function provides unregistered infomations on taxpayer's purchases list among sales list that taxpayer is assigned to transaction party.
        /// </summary>
        Task<SavePurchaseResponse?> SavePurchaseAsync(SavePurchaseRequest requestBody);

        /// <summary>
        /// Save Purchase information.
        /// You can store purchases info in server.
        /// This API function sends the purchase transaction information generated from the taxpayer client and stores it.
        /// </summary>
        Task<TransactionsPurchaseSalesResponse?> SelectTransactionsPurchaseSalesAsync(TransactionsPurchaseSalesRequest requestBody);
    }
}