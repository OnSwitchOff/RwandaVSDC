using RwandaVSDC.Models.JSON.Notices.SelectNotices;

namespace RwandaVSDC.Services.ApiClients.Notices
{
    
    public interface INoticesApiClient
    {
        /// <summary>
        /// Lookup the list of notice.
        /// You can lookup the list of notice in taxpayer client.
        /// This API function provides list of notice registered in the server.
        /// </summary>
        Task<NoticeResponse?> SelectNoticesAsync(NoticeRequest requestBody);
    }
}