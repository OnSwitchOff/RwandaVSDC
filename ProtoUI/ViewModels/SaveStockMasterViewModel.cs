using ReactiveUI;
using RwandaVSDC.Services.ApiClients.StockApiClient;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProtoUI.ViewModels
{
    public class SaveStockMasterViewModel: ViewModelBase
    {
        private readonly IStockApiClient _stockApiClient;

        private string _tin = string.Empty;
        private string _branchId = string.Empty;
        private string _itemCode = string.Empty;
        private string _remainQuantity = string.Empty;
        private string _registrantName = string.Empty;
        private string _registrantId = string.Empty;
        private string _modifierName = string.Empty;
        private string _modifierId = string.Empty;        

        private string _response = string.Empty;
        public IReactiveCommand SendCommand { get; }
        public string Response { get => _response; set => this.RaiseAndSetIfChanged(ref _response, value); }
        public string Tin { get => _tin; set => this.RaiseAndSetIfChanged(ref _tin, value); }
        public string BranchId { get => _branchId; set => this.RaiseAndSetIfChanged(ref _branchId, value); }
        public string ItemCode { get => _itemCode; set => this.RaiseAndSetIfChanged(ref _itemCode, value); }
        public string RemainQuantity { get => _remainQuantity; set => this.RaiseAndSetIfChanged(ref _remainQuantity, value); }
        public string RegistrantName { get => _registrantName; set => this.RaiseAndSetIfChanged(ref _registrantName, value); }
        public string RegistrantId { get => _registrantId; set => this.RaiseAndSetIfChanged(ref _registrantId, value); }
        public string ModifierName { get => _modifierName; set => this.RaiseAndSetIfChanged(ref _modifierName, value); }
        public string ModifierId { get => _modifierId; set => this.RaiseAndSetIfChanged(ref _modifierId, value); }

        public SaveStockMasterViewModel() : base()
        {
            _stockApiClient = new StockApiClient(new HttpApiService(new HttpClient()), new JsonSerializerService());
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
