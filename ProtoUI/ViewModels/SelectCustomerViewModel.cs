using ReactiveUI;
using RwandaVSDC.Services.ApiClients.CodeApiClient;
using RwandaVSDC.Services.ApiClients.CustomersApiClient;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProtoUI.ViewModels
{
    public class SelectCustomerViewModel: ViewModelBase
    {
        private readonly ICustomersApiClient _customersApiClient;

        private string _tin = string.Empty;
        private string _branchId = string.Empty;
        private string _customerTin = string.Empty;
        private string _response = string.Empty;

        public IReactiveCommand SendCommand { get; }
        public string Tin
        {
            get => _tin;
            set => this.RaiseAndSetIfChanged(ref _tin, value);
        }

        public string BranchId
        {
            get => _branchId;
            set => this.RaiseAndSetIfChanged(ref _branchId, value);
        }

        public string CustomerTin
        {
            get => _customerTin;
            set => this.RaiseAndSetIfChanged(ref _customerTin, value);
        }

        public string Response
        {
            get => _response;
            set => this.RaiseAndSetIfChanged(ref _response, value);
        }


        public SelectCustomerViewModel(): base()
        {
            _customersApiClient = new CustomersApiClient(new HttpApiService(new HttpClient()), new JsonSerializerService());
            SendCommand = ReactiveCommand.Create(Send);
        }

        private async Task Send()
        {
            try
            {
                Response = "Request sending..";
                await Task.Delay(1000);
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                Response = e.Message;
            }
        }
    }
}
