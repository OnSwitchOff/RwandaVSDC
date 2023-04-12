using RwandaVSDC.Models.JSON.Stock.SaveStockItems;
using RwandaVSDC.Models.JSON.Stock.SaveStockMaster;
using RwandaVSDC.Models.JSON.Stock.SelectStockItems;

namespace RwandaVSDC.Services.ApiClients.StockApiClient
{
    public interface IStockApiClient
    {
        /// <summary>
        /// Save stock in/out.
        /// You can store taxpayer stock in/out information in server.
        /// This API function performs storing stock in/out data registered by taxpayer client of head/branch in the server.
        /// </summary>
        Task<SaveStockResponse?> SaveStockItemsAsync(SaveStockRequest requestBody);

        /// <summary>
        /// Save stock master information.
        /// You can store the stock master information in server.
        /// This API function saves the inventory master information managed by taxpayer client to the server.
        /// </summary>
        Task<SaveStockMasterResponse?> SaveStockMasterAsync(SaveStockMasterRequest requestBody);

        /// <summary>
        /// Lookup the list of stock movement.
        /// You can look up the stock movement list in server.
        /// This API function provides the result of the shifting stock quantity between the head office and the branches.
        /// </summary>
        Task<StockMovementResponse?> SelectStockItemsAsync(StockMovementRequest requestBody);
    }
}