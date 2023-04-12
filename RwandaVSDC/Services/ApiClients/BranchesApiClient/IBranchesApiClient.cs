using Microsoft.VisualBasic;
using RwandaVSDC.Models.JSON.Branches.SaveBrancheCustomers;
using RwandaVSDC.Models.JSON.Branches.SaveBrancheInsurances;
using RwandaVSDC.Models.JSON.Branches.SaveBrancheUsers;
using RwandaVSDC.Models.JSON.Branches.SelectBranches;

namespace RwandaVSDC.Services.ApiClients.BranchesApiClient
{
    public interface IBranchesApiClient
    {
        /// <summary>
        /// Save customer of branch.
        /// You can store branch infomation in server for recover the client data.
        /// This API function stores the client customer information managed by the store on the server.
        /// </summary>
        Task<SaveBranchCustomerResponse?> SaveBrancheCustomersAsync(SaveBranchCustomerRequest requestBody);

        /// <summary>
        /// Save Insurance company information of branch.
        /// You can save insurance company information which taxpayer branch uses in server.
        /// This API function performs storing the insurance company information managed by taxpayer pharmacy.
        /// </summary>
        Task<SaveBranchInsuranceResponse?> SaveBrancheInsurancesAsync(SaveBranchInsuranceRequest requestBody);

        /// <summary>
        /// Save branch user account.
        /// You can store branch user account in server.
        /// This API function stores the user account information of taxpayer branch in server
        /// </summary>
        Task<SaveBranchUserResponse?> SaveBrancheUsersAsync(SaveBranchUserRequest requestBody);

        /// <summary>
        /// Lookup list of taxpayer branch information.
        /// You can lookup list of taxpayer branch information registered in server. 
        /// This API function provides every information of taxpayer branch.
        /// </summary>
        Task<BranchResponse?> SelectBranchesAsync(BranchRequest requestBody);
    }
}