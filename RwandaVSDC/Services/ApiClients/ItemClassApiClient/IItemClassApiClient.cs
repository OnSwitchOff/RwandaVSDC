using RwandaVSDC.Models.JSON.ItemClass.SelectItemsClass;

namespace RwandaVSDC.Services.ApiClients.ItemClassApiClient
{
    public interface IItemClassApiClient
    {
        /// <summary>
        /// Lookup list of item classification.
        /// You can lookup list of item classification registered in server with this function. 
        /// This API function provides item category and item list at once.
        /// </summary>
        Task<ItemClassResponse?> SelectItemsClassAsync(ItemClassRequest requestBody);
    }
}