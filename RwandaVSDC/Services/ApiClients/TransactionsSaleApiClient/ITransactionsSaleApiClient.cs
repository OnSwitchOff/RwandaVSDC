using RwandaVSDC.Models.JSON.TransactionsSales.SaveSales;

namespace RwandaVSDC.Services.ApiClients.TransactionsSaleApiClient
{
    public interface ITransactionsSaleApiClient
    {
        /// <summary>
        /// Save sales transaction.
        /// You can save sales transaction information in server.
        /// This API function transfers the transaction information of taxpayer client’s sales to the server.
        /// </summary>
        Task<SaveSalesResponse?> SaveSalesAsync(SaveSalesRequest requestBody);
    }
}