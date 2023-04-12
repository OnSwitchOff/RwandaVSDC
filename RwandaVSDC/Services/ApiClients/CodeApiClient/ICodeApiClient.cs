using RwandaVSDC.Models.JSON.Code.SelectCodes;

namespace RwandaVSDC.Services.ApiClients.CodeApiClient
{
    public interface ICodeApiClient
    {
        /// <summary>
        /// Lookup list of code.
        /// You can lookup common code list registered in server with this function.
        /// This API function provides code classification and code detail at once.
        /// </summary>
        Task<CodeResponse?> SelectCodeAsync(CodeRequest codeRequest);
    }
}