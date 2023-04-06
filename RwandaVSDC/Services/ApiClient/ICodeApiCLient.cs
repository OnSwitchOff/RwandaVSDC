using RwandaVSDC.Models.JSON.Code.SelectCodes;

namespace RwandaVSDC.Services.ApiClient
{
    public interface ICodeApiCLient
    {
        Task<CodeResponse?> SelectCodeAsync(CodeRequest codeRequest);
    }
}