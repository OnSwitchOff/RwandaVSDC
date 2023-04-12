using RwandaVSDC.Models.JSON.Customers.SelectCustomer;

namespace RwandaVSDC.Services.ApiClients.CustomersApiClient
{
    public interface ICustomersApiClient
    {
        /// <summary>
        /// Retrieve information for a specified TIN(customer).
        /// This API function synchronizes the taxpayer information registered on the server with client.
        /// </summary>
        Task<CustomerResponse?> SelectCustomerAsync(CustomerRequest requestBody);
    }
}