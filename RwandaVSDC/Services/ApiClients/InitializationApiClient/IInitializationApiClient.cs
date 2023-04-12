using Microsoft.VisualBasic;
using RwandaVSDC.Models.JSON.Initialization.SelectInitInfo;

namespace RwandaVSDC.Services.ApiClients.InitializationApiClient
{
    public interface IInitializationApiClient
    {
        /// <summary>
        /// Lookup initial setup information of VSDC Device.
        /// You can lookup the initial configuration information registered in the server.
        /// This function provides authenticated information of VSDC device.
        /// </summary>
        Task<InitInfoResponse?> SelectInitInfoAsync(InitInfoRequest requestBody);
    }
}