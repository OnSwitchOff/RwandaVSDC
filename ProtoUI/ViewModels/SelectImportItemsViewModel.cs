using ReactiveUI;
using RwandaVSDC.Services.ApiClients.ImportsApiClient;
using RwandaVSDC.Services.ApiClients.ItemClassApiClient;
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
    public class SelectImportItemsViewModel: ViewModelBase
    {
        private readonly IImportsApiClient _importsClassApiClient;

        private string _tin = string.Empty;
        private string _branchId = string.Empty;
        private string _lastRequestDate = string.Empty;
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

        public string LastRequestDate
        {
            get => _lastRequestDate;
            set => this.RaiseAndSetIfChanged(ref _lastRequestDate, value);
        }

        public string Response
        {
            get => _response;
            set => this.RaiseAndSetIfChanged(ref _response, value);
        }

        public SelectImportItemsViewModel() : base()
        {
            _importsClassApiClient = new ImportsApiClient(new HttpApiService(new HttpClient()), new JsonSerializerService());
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
