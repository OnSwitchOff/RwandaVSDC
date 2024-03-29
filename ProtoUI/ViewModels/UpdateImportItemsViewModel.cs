﻿using ReactiveUI;
using RwandaVSDC.Models.Data;
using RwandaVSDC.Services.ApiClients.ImportsApiClient;
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
    public class UpdateImportItemsViewModel: ViewModelBase
    {
        private readonly IImportsApiClient _importsApiClient;
        private readonly IJsonSerializerService _jsonSerializer;

        private string _tin = SD.TIN;
        private string _branchId = SD.BranchID;
        private string _taskCode = string.Empty;
        private string _declarationDate = string.Empty;
        private uint _itemSequence = 0;
        private string _hSCode = string.Empty;
        private string _itemClassificationCode = string.Empty;
        private string _itemCode = string.Empty;
        private string _importItemStatusCode = string.Empty;
        public CodeInfo? _selectedImportItemStatus = null;
        private string _remark = string.Empty;
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
        public string TaskCode { get => _taskCode; set => this.RaiseAndSetIfChanged(ref _taskCode, value); }
        public string DeclarationDate { get => _declarationDate; set => this.RaiseAndSetIfChanged(ref _declarationDate, value); }
        public uint ItemSequence { get => _itemSequence; set => this.RaiseAndSetIfChanged(ref _itemSequence, value); }
        public string HSCode { get => _hSCode; set => this.RaiseAndSetIfChanged(ref _hSCode, value); }
        public string ItemClassificationCode { get => _itemClassificationCode; set => this.RaiseAndSetIfChanged(ref _itemClassificationCode, value); }
        public string ItemCode { get => _itemCode; set => this.RaiseAndSetIfChanged(ref _itemCode, value); }
        public string ImportItemStatusCode { get => _importItemStatusCode; set => this.RaiseAndSetIfChanged(ref _importItemStatusCode, value); }
        public string Remark { get => _remark; set => this.RaiseAndSetIfChanged(ref _remark, value); }
        public string ModifierName { get => _modifierName; set => this.RaiseAndSetIfChanged(ref _modifierName, value); }
        public string ModifierId { get => _modifierId; set => this.RaiseAndSetIfChanged(ref _modifierId, value); }
        public string Response
        {
            get => _response;
            set => this.RaiseAndSetIfChanged(ref _response, value);
        }
        public IReadOnlyList<CodeInfo> ImportItemStatuses { get; set; }
        public CodeInfo? SelectedImportItemStatus
        {
            get => _selectedImportItemStatus;
            set
            {
                this.RaiseAndSetIfChanged(ref _selectedImportItemStatus, value);
                ImportItemStatusCode = _selectedImportItemStatus?.Code ?? string.Empty;
            }
        }

        public UpdateImportItemsViewModel() : base()
        {
            _importsApiClient = new ImportsApiClient(new HttpApiService(new HttpClient()), new JsonSerializerService());
            _jsonSerializer = new JsonSerializerService();
            SendCommand = ReactiveCommand.Create(Send);
            ImportItemStatuses = ImportItemsStatusCodes.Codes.Select(kv => kv.Value).ToList();
        }

        private async Task Send()
        {
            try
            {
                Response = "Request sending.."; 
                var response = await _importsApiClient.UpdateImportItemsAsync(new RwandaVSDC.Models.JSON.Imports.UpdateImportItems.UpdateImportItemRequest()
                {
                    Tin = Tin,
                    BranchId = BranchId,
                    TaskCode = TaskCode,
                    DeclarationDate = DeclarationDate,
                    ItemSequence = ItemSequence,
                    HSCode = HSCode,
                    ItemClassificationCode = ItemClassificationCode,
                    ItemCode = ItemCode,
                    ImportItemStatusCode = ImportItemStatusCode,
                    Remark = Remark,
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
