using ReactiveUI;
using RwandaVSDC.Services.ApiClients.NoticesApiClient;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using RwandaVSDC.Services.ApiClients.BranchesApiClient;

namespace ProtoUI.ViewModels
{
    public class SaveBrancheCustomersViewModel : ViewModelBase
    {
        private readonly IBranchesApiClient _branchesApiClient;
        private readonly IJsonSerializerService _jsonSerializer;

        private string _tin = SD.TIN;
        private string _branchId = SD.BranchID;
        private string _customerNumber = string.Empty;
        private string _customerTin = string.Empty;
        private string _customerName = string.Empty;
        private string _address = string.Empty;
        private string _contact = string.Empty;
        private string _email = string.Empty;
        private string _faxNumber = string.Empty;
        private string _usedYesNo = string.Empty;
        private string _remark = string.Empty;
        private string _registrantName = SD.RegistrantName;
        private string _registrantId = SD.RegistrantID;
        private string _modifierName = SD.ModifierName;
        private string _modifierId = SD.ModifierID;

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


        public string Response
        {
            get => _response;
            set => this.RaiseAndSetIfChanged(ref _response, value);
        }
        public string CustomerNumber
        { 
            get => _customerNumber;
            set => this.RaiseAndSetIfChanged(ref _customerNumber, value);
        }
        public string CustomerTin
        { 
            get => _customerTin;
            set => this.RaiseAndSetIfChanged(ref _customerTin, value);
        }
        public string CustomerName
        { 
            get => _customerName;
            set => this.RaiseAndSetIfChanged(ref _customerName, value);
        }
        public string Address 
        { 
            get => _address;
            set => this.RaiseAndSetIfChanged(ref _address, value);
        }
        public string Contact
        { 
            get => _contact;
            set => this.RaiseAndSetIfChanged(ref _contact, value); 
        }
        public string Email
        {
            get => _email;
            set => this.RaiseAndSetIfChanged(ref _email, value);
        }
        public string FaxNumber
        {
            get => _faxNumber;
            set => this.RaiseAndSetIfChanged(ref _faxNumber, value);
        }
        public string UsedYesNo
        { 
            get => _usedYesNo; 
            set => this.RaiseAndSetIfChanged(ref _usedYesNo, value);
        }
        public string Remark
        { 
            get => _remark; 
            set => this.RaiseAndSetIfChanged(ref _remark, value);
        }
        public string RegistrantName
        { 
            get => _registrantName; 
            set => this.RaiseAndSetIfChanged(ref _registrantName, value);
        }
        public string RegistrantId 
        { 
            get => _registrantId;
            set => this.RaiseAndSetIfChanged(ref _registrantId, value);
        }
        public string ModifierName
        { 
            get => _modifierName; 
            set => this.RaiseAndSetIfChanged(ref _modifierName, value);
        }
        public string ModifierId
        {
            get => _modifierId;
            set => this.RaiseAndSetIfChanged(ref _modifierId, value);
        }

        public SaveBrancheCustomersViewModel() : base()
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
                var response = await _branchesApiClient.SaveBrancheCustomersAsync(new RwandaVSDC.Models.JSON.Branches.SaveBrancheCustomers.SaveBranchCustomerRequest()
                {
                    Tin = Tin,
                    BranchId = BranchId,
                    CustomerName = CustomerName,
                    CustomerNumber = CustomerNumber,
                    CustomerTIN = CustomerTin,
                    Address = Address,
                    Contact = Contact,
                    Email = Email,
                    FaxNumber = FaxNumber,
                    UsedYesNo = UsedYesNo,
                    Remark = Remark,
                    RegistrantName = RegistrantName,
                    RegistrantID = RegistrantId,
                    ModifierName = ModifierName,
                    ModifierID = ModifierId
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