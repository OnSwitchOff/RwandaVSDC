﻿using ReactiveUI;
using RwandaVSDC.Services.ApiClients.CodeApiClient;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using RwandaVSDC.Services.ApiClients.BranchesApiClient;

namespace ProtoUI.ViewModels
{
    public class SelectBranchesViewModel: ViewModelBase
    {
        private readonly IBranchesApiClient _branchesApiClient;
        private readonly IJsonSerializerService _jsonSerializer;

        private string _tin = SD.TIN;
        private string _branchId = SD.BranchID;
        private string _lastRequestDate = SD.LastRequestDate;
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

        public SelectBranchesViewModel() : base()
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
                var response = await _branchesApiClient.SelectBranchesAsync(new RwandaVSDC.Models.JSON.Branches.SelectBranches.BranchRequest()
                {
                    Tin = Tin,
                    BranchId = BranchId,
                    LastRequestDate = LastRequestDate
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