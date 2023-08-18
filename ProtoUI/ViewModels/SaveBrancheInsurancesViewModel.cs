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
        private readonly IJsonSerializerService _jsonSerializer;

        private string _tin = SD.TIN;
        private string _branchId = SD.BranchID;
        private string _insuranceCode = string.Empty;
        private string _insuranceName = string.Empty;
        private uint _premiumRate = 0;
        private string _usedYesNo = string.Empty;
        private string _registrantName = SD.RegistrantName;
        private string _registrantId = SD.RegistrantID;
        private string _modifierName = SD.ModifierName;
        private string _modifierId = SD.ModifierID;

        private string _response = string.Empty;

        public IReactiveCommand SendCommand { get; }
        public string Tin { get => _tin; set => this.RaiseAndSetIfChanged(ref _tin, value); }
        public string BranchId { get => _branchId; set => this.RaiseAndSetIfChanged(ref _branchId, value); }
        public string InsuranceCode { get => _insuranceCode; set => this.RaiseAndSetIfChanged(ref _insuranceCode, value); }
        public string InsuranceName { get => _insuranceName; set => this.RaiseAndSetIfChanged(ref _insuranceName, value); }
        public uint PremiumRate { get => _premiumRate; set => this.RaiseAndSetIfChanged(ref _premiumRate, value); }
        public string UsedYesNo { get => _usedYesNo; set => this.RaiseAndSetIfChanged(ref _usedYesNo, value); }
        public string RegistrantName { get => _registrantName; set => this.RaiseAndSetIfChanged(ref _registrantName, value); }
        public string RegistrantId { get => _registrantId; set => this.RaiseAndSetIfChanged(ref _registrantId, value); }
        public string ModifierName { get => _modifierName; set => this.RaiseAndSetIfChanged(ref _modifierName, value); }
        public string ModifierId { get => _modifierId; set => this.RaiseAndSetIfChanged(ref _modifierId, value); }
        public string Response { get => _response; set => this.RaiseAndSetIfChanged(ref _response, value); }

        public SaveBrancheInsurancesViewModel() : base()
        {
            _branchesApiClient = new BranchesApiClient(new HttpApiService(new HttpClient()), new JsonSerializerService());
            _jsonSerializer = new JsonSerializerService();
            SendCommand = ReactiveCommand.Create(Send);
        }

        private async Task Send()
        {
            try
            {
                Response = "Request sending..";
                var response = await _branchesApiClient.SaveBrancheInsurancesAsync(new RwandaVSDC.Models.JSON.Branches.SaveBrancheInsurances.SaveBranchInsuranceRequest()
                {
                    Tin = Tin,
                    BranchId = BranchId,
                    InsuranceCode = InsuranceCode,
                    InsuranceName = InsuranceName,
                    PremiumRate = PremiumRate,
                    UsedYesNo = UsedYesNo,
                    RegistrantName = RegistrantName,
                    RegistrantID = RegistrantId,
                    ModifierID = ModifierId,
                    ModifierName = ModifierName
                });
                Response = _jsonSerializer.Serialize(response) ?? "NullResponse";
                SD.LastRequestDate = response?.ResultDate ?? DateTime.Now.ToString("yyyyMMddHHmmss");
            }
            catch (Exception e)
            {
                Response = e.Message;
            }
        }
    }
}
