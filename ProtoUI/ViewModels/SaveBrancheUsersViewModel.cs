using ReactiveUI;
using RwandaVSDC.Services.ApiClients.BranchesApiClient;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProtoUI.ViewModels
{
    public class SaveBrancheUsersViewModel: ViewModelBase
    {
        private readonly IBranchesApiClient _branchesApiClient;
        private readonly IJsonSerializerService _jsonSerializer;

        private string _tin = SD.TIN;
        private string _branchId = SD.BranchID;
        private string _userId = string.Empty;
        private string _userName = string.Empty;
        private string _password = string.Empty;
        private string _address = string.Empty;
        private string _contact = string.Empty;
        private string _authorityCode = string.Empty;
        private string _remark = string.Empty;
        private string _usedYesNo = string.Empty;
        private string _registrantName = SD.RegistrantName;
        private string _registrantId = SD.RegistrantID;
        private string _modifierName = SD.ModifierName;
        private string _modifierId = SD.ModifierID;

        private string _response = string.Empty;

        public IReactiveCommand SendCommand { get; }
        public string Tin { get => _tin; set => this.RaiseAndSetIfChanged(ref _tin, value); }
        public string BranchId { get => _branchId; set => this.RaiseAndSetIfChanged(ref _branchId, value); }
        public string UserId { get => _userId; set => this.RaiseAndSetIfChanged(ref _userId, value); }
        public string UserName { get => _userName; set => this.RaiseAndSetIfChanged(ref _userName, value); }
        public string Password { get => _password; set => this.RaiseAndSetIfChanged(ref _password, value); }
        public string Address { get => _address; set => this.RaiseAndSetIfChanged(ref _address, value); }
        public string Contact { get => _contact; set => this.RaiseAndSetIfChanged(ref _contact, value); }
        public string AuthorityCode { get => _authorityCode; set => this.RaiseAndSetIfChanged(ref _authorityCode, value); }
        public string Remark { get => _remark; set => this.RaiseAndSetIfChanged(ref _remark, value); }
        public string UsedYesNo { get => _usedYesNo; set => this.RaiseAndSetIfChanged(ref _usedYesNo, value); }
        public string RegistrantName { get => _registrantName; set => this.RaiseAndSetIfChanged(ref _registrantName, value); }
        public string RegistrantId { get => _registrantId; set => this.RaiseAndSetIfChanged(ref _registrantId, value); }
        public string ModifierName { get => _modifierName; set => this.RaiseAndSetIfChanged(ref _modifierName, value); }
        public string ModifierId { get => _modifierId; set => this.RaiseAndSetIfChanged(ref _modifierId, value); }
        public string Response { get => _response; set => this.RaiseAndSetIfChanged(ref _response, value); }

        public SaveBrancheUsersViewModel() : base()
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
                var response = await _branchesApiClient.SaveBrancheUsersAsync(new RwandaVSDC.Models.JSON.Branches.SaveBrancheUsers.SaveBranchUserRequest()
                {
                    Tin = Tin,
                    BranchId = BranchId,
                    UserID = UserId,
                    UserName = UserName,
                    Password = Password,
                    Address = Address,
                    Contact = Contact,
                    AuthorityCode = AuthorityCode,
                    Remark = Remark,
                    UsedYesNo = UsedYesNo,
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
