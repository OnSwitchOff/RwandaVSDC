﻿using ReactiveUI;
using RwandaVSDC.Services.ApiClients.CodeApiClient;
using RwandaVSDC.Services.ApiClients.TransactionsPurchaseApiClient;
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
    public class SelectTransactionsPurchaseSalesViewModel : ViewModelBase
    {
        private readonly ITransactionsPurchaseApiClient _transactionsPurchaseApiClient;
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

        public SelectTransactionsPurchaseSalesViewModel() : base()
        {
            _transactionsPurchaseApiClient = new TransactionsPurchaseApiClient(new HttpApiService(new HttpClient()), new JsonSerializerService());
            _jsonSerializer = new JsonSerializerService();
            SendCommand = ReactiveCommand.Create(Send);
        }

        private async Task Send()
        {
            try
            {
                Response = "Request sending..";
                var response = await _transactionsPurchaseApiClient.SelectTransactionsPurchaseSalesAsync(new RwandaVSDC.Models.JSON.TransactionsPurchase.SelectTransactionsPurchaseSales.TransactionsPurchaseSalesRequest()
                { 
                    BranchId = BranchId, LastRequestDate = LastRequestDate, Tin = Tin
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
