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

        private string _tin = string.Empty;
        private string _branchId = string.Empty;
        private string _customerNumber = string.Empty;
        private string _customerTin = string.Empty;
        private string _customerName = string.Empty;
        private string _address = string.Empty;
        private string _contact = string.Empty;
        private string _email = string.Empty;
        private string _faxNumber = string.Empty;
        private string _usedYesNo = string.Empty;
        private string _remark = string.Empty;
        private string _registrantName = string.Empty;
        private string _registrantId = string.Empty;
        private string _modifierName = string.Empty;
        private string _modifierId = string.Empty;

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