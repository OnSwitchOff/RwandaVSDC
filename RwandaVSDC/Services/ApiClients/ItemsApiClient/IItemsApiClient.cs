using RwandaVSDC.Models.JSON.Items.SaveItems;
using RwandaVSDC.Models.JSON.Items.SelectItems;

namespace RwandaVSDC.Services.ApiClients.ItemsApiClient
{
    public interface IItemsApiClient
    {
        /// <summary>
        /// You can save the product information in server.
        /// This API function performs storing item information managed by the taxpayer client in the server.
        /// </summary>
        Task<SaveItemResponse?> SaveItemsAsync(SaveItemRequest requestBody);

        /// <summary>
        /// Lookup list of item(product)
        /// You can lookup the list of Item information in server. 
        /// This API function provides list of product information for taxpayer registered in the server.
        /// </summary>
        Task<ItemResponse?> SelectItemsAsync(ItemRequest requestBody);
    }
}