using RwandaVSDC.Models.JSON.Imports.SelectImportItems;
using RwandaVSDC.Models.JSON.Imports.UpdateImportItems;

namespace RwandaVSDC.Services.ApiClients.ImportsApiClient
{
    public interface IImportsApiClient
    {
        /// <summary>
        /// Lookup list of imported item.
        /// You can lookup list of taxpayer’s imported item in server. This API function provides information of taxpayer’s imported item in server
        /// </summary>
        Task<ImportItemResponse?> SelectItemsAsync(ImportItemRequest requestBody);

        /// <summary>
        /// Revise imported item.
        /// You can revise imported item information in server. The taxpayer adds the imported items to item and purchase date at the client.
        /// The imported item information is transferred to the server through this API function.
        /// </summary>
        Task<UpdateImportItemResponse?> UpdateImportItemsAsync(UpdateImportItemRequest requestBody);
    }
}