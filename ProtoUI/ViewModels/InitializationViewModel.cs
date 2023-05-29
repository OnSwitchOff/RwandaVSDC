using Newtonsoft.Json;
using ReactiveUI;
using RwandaVSDC.Models.JSON.Initialization.SelectInitInfo;
using RwandaVSDC.Services.ApiClients.InitializationApiClient;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProtoUI.ViewModels
{
    public class InitializationViewModel : ViewModelBase
    {
        private readonly IInitializationApiClient _initializationApiClient;

        private string _tin = string.Empty;
        private string _branchId = string.Empty;
        private string _deviceSerialNumber = string.Empty;
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

        public string DeviceSerialNumber
        {
            get => _deviceSerialNumber;
            set => this.RaiseAndSetIfChanged(ref _deviceSerialNumber, value);
        }

        public string Response
        {
            get => _response;
            set => this.RaiseAndSetIfChanged(ref _response, value);
        }

        public InitializationViewModel() : base()
        {
            _initializationApiClient = new InitializationApiClient(new HttpApiService(new HttpClient()), new JsonSerializerService());
            SendCommand = ReactiveCommand.Create(Send);
        }

        private async Task Send()
        {
            try
            {
                Response = "Request sending..";
                await Task.Delay(1000);      
                var response = await _initializationApiClient.SelectInitInfoAsync(new InitInfoRequest()
                {
                    Tin = _tin,
                    BranchId = _branchId,
                    DvcSrlNo = _deviceSerialNumber
                });

                Response = response is null ?
                    "NullResponse" : 
                    $"ResultDate:{response?.ResultDate}\n" +
                    $"ResultCode:{response?.ResultCode}\n" +
                    $"ResultMessage:{response?.ResultMessage}\n";
            }
            catch (Exception e)
            {
                Response = e.Message;
            }    
        }
    }
}