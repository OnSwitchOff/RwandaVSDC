using ReactiveUI;
using RwandaVSDC.Services.ApiClients.BranchesApiClient;
using RwandaVSDC.Services.ApiClients.NoticesApiClient;
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
    public class SaveBrancheInsurancesViewModel: ViewModelBase
    {
        private readonly IBranchesApiClient _branchesApiClient;

        private string _tin = string.Empty;
        private string _branchId = string.Empty;
        private string _insuranceCode = string.Empty;
        private string _insuranceName = string.Empty;
        private string _premiumRate = string.Empty;
        private string _usedYesNo = string.Empty;
        private string _registrantName = string.Empty;
        private string _registrantId = string.Empty;
        private string _modifierName = string.Empty;
        private string _modifierId = string.Empty;

        private string _response = string.Empty;

        public IReactiveCommand SendCommand { get; }
        public string Tin { get => _tin; set => this.RaiseAndSetIfChanged(ref _tin, value); }
        public string BranchId { get => _branchId; set => this.RaiseAndSetIfChanged(ref _branchId, value); }
        public string InsuranceCode { get => _insuranceCode; set => this.RaiseAndSetIfChanged(ref _insuranceCode, value); }
        public string InsuranceName { get => _insuranceName; set => this.RaiseAndSetIfChanged(ref _insuranceName, value); }
        public string PremiumRate { get => _premiumRate; set => this.RaiseAndSetIfChanged(ref _premiumRate, value); }
        public string UsedYesNo { get => _usedYesNo; set => this.RaiseAndSetIfChanged(ref _usedYesNo, value); }
        public string RegistrantName { get => _registrantName; set => this.RaiseAndSetIfChanged(ref _registrantName, value); }
        public string RegistrantId { get => _registrantId; set => this.RaiseAndSetIfChanged(ref _registrantId, value); }
        public string ModifierName { get => _modifierName; set => this.RaiseAndSetIfChanged(ref _modifierName, value); }
        public string ModifierId { get => _modifierId; set => this.RaiseAndSetIfChanged(ref _modifierId, value); }
        public string Response { get => _response; set => this.RaiseAndSetIfChanged(ref _response, value); }

        public SaveBrancheInsurancesViewModel() : base()
        {
            _branchesApiClient = new BranchesApiClient(new HttpApiService(new HttpClient()), new JsonSerializerService());
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
