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
        private readonly IJsonSerializerService _jsonSerializer;

        private string _tin = SD.TIN;
        private string _branchId = SD.BranchID;
        private string _itemCode = string.Empty;
        private decimal _remainQuantity = 0m;
        private string _registrantName = SD.RegistrantName;
        private string _registrantId = SD.RegistrantID;
        private string _modifierName = SD.ModifierName;
        private string _modifierId = SD.ModifierID;        

        private string _response = string.Empty;
        public IReactiveCommand SendCommand { get; }
        public string Response { get => _response; set => this.RaiseAndSetIfChanged(ref _response, value); }
        public string Tin { get => _tin; set => this.RaiseAndSetIfChanged(ref _tin, value); }
        public string BranchId { get => _branchId; set => this.RaiseAndSetIfChanged(ref _branchId, value); }
        public string ItemCode { get => _itemCode; set => this.RaiseAndSetIfChanged(ref _itemCode, value); }
        public decimal RemainQuantity { get => _remainQuantity; set => this.RaiseAndSetIfChanged(ref _remainQuantity, value); }
        public string RegistrantName { get => _registrantName; set => this.RaiseAndSetIfChanged(ref _registrantName, value); }
        public string RegistrantId { get => _registrantId; set => this.RaiseAndSetIfChanged(ref _registrantId, value); }
        public string ModifierName { get => _modifierName; set => this.RaiseAndSetIfChanged(ref _modifierName, value); }
        public string ModifierId { get => _modifierId; set => this.RaiseAndSetIfChanged(ref _modifierId, value); }

        public SaveStockMasterViewModel() : base()
        {
            _stockApiClient = new StockApiClient(new HttpApiService(new HttpClient()), new JsonSerializerService());
            _jsonSerializer = new JsonSerializerService();
            SendCommand = ReactiveCommand.Create(Send);
        }

        private async Task Send()
        {
            try
            {
                Response = "Request sending.."; 
                var response = await _stockApiClient.SaveStockMasterAsync(new RwandaVSDC.Models.JSON.Stock.SaveStockMaster.SaveStockMasterRequest()
                {
                    BranchId = BranchId,
                    Tin = Tin,
                    ItemCode = ItemCode,
                    RemainQuantity = RemainQuantity,
                    RegistrantId = RegistrantId,
                    RegistrantName = RegistrantName,
                    ModifierId = ModifierId,
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
