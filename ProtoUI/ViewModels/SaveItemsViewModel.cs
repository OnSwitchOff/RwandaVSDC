using ReactiveUI;
using RwandaVSDC.Models.Data;
using RwandaVSDC.Models.Enums;
using RwandaVSDC.Services.ApiClients.BranchesApiClient;
using RwandaVSDC.Services.ApiClients.ItemsApiClient;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.ItemCodeBuilder;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace ProtoUI.ViewModels
{
    public class SaveItemsViewModel: ViewModelBase
    {
        private readonly IItemsApiClient _itemsApiClient;
        private readonly IJsonSerializerService _jsonSerializer;

        private string _tin = SD.TIN;
        private string _branchId = SD.BranchID;
        private string _itemCode = string.Empty;
        private string _itemClassificationCode = string.Empty;
        private string _itemTypeCode = string.Empty;
        private CodeInfo? _selectedProductType = null;
        private string _itemName = string.Empty;
        private string _itemStandartName = string.Empty;
        private string _originPlaceCode = string.Empty;
        private CodeInfo? _originPlace = null;
        private string _packagingUnitCode = string.Empty;
        private CodeInfo? _selectedPackagingUnit = null;
        private string _quantityUnitCode = string.Empty;
        private CodeInfo? _selectedUnitOfQuantityCode = null;
        private string _taxationTypeCode = string.Empty;
        private CodeInfo? _selectedTaxType = null;
        private string _batchNumber = string.Empty;
        private string _barcode = string.Empty;
        private decimal _defaultUnitPrice = 0;
        private decimal? _group1UnitPrice = null;
        private decimal? _group2UnitPrice = null;
        private decimal? _group3UnitPrice = null;
        private decimal? _group4UnitPrice = null;
        private decimal? _group5UnitPrice = null;
        private string _additionalInfo = string.Empty;
        private decimal? _saftyQuantity = null;
        private string _insuranceAppicableYesNo = string.Empty;
        private string _usedYesNo = string.Empty;
        private string _registrantName = SD.RegistrantName;
        private string _registrantId = SD.RegistrantID;
        private string _modifierName = SD.ModifierName;
        private string _modifierId = SD.ModifierID;


        private string _response = string.Empty;

        public IReactiveCommand SendCommand { get; }
        public string Tin { get => _tin; set => this.RaiseAndSetIfChanged(ref _tin, value); }
        public string BranchId { get => _branchId; set => this.RaiseAndSetIfChanged(ref _branchId, value); }
        public string ItemCode { get => _itemCode; set => this.RaiseAndSetIfChanged(ref _itemCode, value); }
        public string ItemClassificationCode { get => _itemClassificationCode; set => this.RaiseAndSetIfChanged(ref _itemClassificationCode, value); }
        public string ItemTypeCode { get => _itemTypeCode; set => this.RaiseAndSetIfChanged(ref _itemTypeCode, value); }
        public string ItemName { get => _itemName; set => this.RaiseAndSetIfChanged(ref _itemName, value); }
        public string ItemStandartName { get => _itemStandartName; set => this.RaiseAndSetIfChanged(ref _itemStandartName, value); }
        public string OriginPlaceCode { get => _originPlaceCode; set => this.RaiseAndSetIfChanged(ref _originPlaceCode, value); }
        public string PackagingUnitCode { get => _packagingUnitCode; set => this.RaiseAndSetIfChanged(ref _packagingUnitCode, value); }
        public string QuantityUnitCode { get => _quantityUnitCode; set => this.RaiseAndSetIfChanged(ref _quantityUnitCode, value); }
        public string TaxationTypeCode { get => _taxationTypeCode; set => this.RaiseAndSetIfChanged(ref _taxationTypeCode, value); }
        public string BatchNumber { get => _batchNumber; set => this.RaiseAndSetIfChanged(ref _batchNumber, value); }
        public string Barcode { get => _barcode; set => this.RaiseAndSetIfChanged(ref _barcode, value); }
        public decimal DefaultUnitPrice { get => _defaultUnitPrice; set => this.RaiseAndSetIfChanged(ref _defaultUnitPrice, value); }
        public decimal? Group1UnitPrice { get => _group1UnitPrice; set => this.RaiseAndSetIfChanged(ref _group1UnitPrice, value); }
        public decimal? Group2UnitPrice { get => _group2UnitPrice; set => this.RaiseAndSetIfChanged(ref _group2UnitPrice, value); }
        public decimal? Group3UnitPrice { get => _group3UnitPrice; set => this.RaiseAndSetIfChanged(ref _group3UnitPrice, value); }
        public decimal? Group4UnitPrice { get => _group4UnitPrice; set => this.RaiseAndSetIfChanged(ref _group4UnitPrice, value); }
        public decimal? Group5UnitPrice { get => _group5UnitPrice; set => this.RaiseAndSetIfChanged(ref _group5UnitPrice, value); }
        public string AdditionalInfo { get => _additionalInfo; set => this.RaiseAndSetIfChanged(ref _additionalInfo, value); }
        public decimal? SaftyQuantity { get => _saftyQuantity; set => this.RaiseAndSetIfChanged(ref _saftyQuantity, value); }
        public string UsedYesNo { get => _usedYesNo; set => this.RaiseAndSetIfChanged(ref _usedYesNo, value); }
        public string RegistrantName { get => _registrantName; set => this.RaiseAndSetIfChanged(ref _registrantName, value); }
        public string RegistrantId { get => _registrantId; set => this.RaiseAndSetIfChanged(ref _registrantId, value); }
        public string ModifierName { get => _modifierName; set => this.RaiseAndSetIfChanged(ref _modifierName, value); }
        public string ModifierId { get => _modifierId; set => this.RaiseAndSetIfChanged(ref _modifierId, value); }
        public string Response { get => _response; set => this.RaiseAndSetIfChanged(ref _response, value); }
        public string InsuranceAppicableYesNo { get => _insuranceAppicableYesNo; set => this.RaiseAndSetIfChanged(ref _insuranceAppicableYesNo, value); }

        public IReadOnlyList<CodeInfo> Nations { get; set; }
        public CodeInfo? SelectedOriginPlace
        { 
            get => _originPlace;
            set 
            {
                this.RaiseAndSetIfChanged(ref _originPlace, value);
                OriginPlaceCode = _originPlace?.Code ?? string.Empty;
                RefreshItemCode();
            }
        }
        public IReadOnlyList<CodeInfo> ProductTypes { get; set; }
        public CodeInfo? SelectedProductType
        {
            get => _selectedProductType;
            set
            {
                this.RaiseAndSetIfChanged(ref _selectedProductType, value);
                ItemTypeCode = _selectedProductType?.Code ?? string.Empty;
                RefreshItemCode();
            }
        }
        public IReadOnlyList<CodeInfo> PackagingUnits { get; set; }
        public CodeInfo? SelectedPackagingUnit
        {
            get => _selectedPackagingUnit;
            set
            {
                this.RaiseAndSetIfChanged(ref _selectedPackagingUnit, value);
                PackagingUnitCode = _selectedPackagingUnit?.Code ?? string.Empty;
                RefreshItemCode();
            }
        }
        public IReadOnlyList<CodeInfo> QuantityUnitCodes { get; set; }
        public CodeInfo? SelectedUnitOfQuantityCode
        {
            get => _selectedUnitOfQuantityCode;
            set
            {
                this.RaiseAndSetIfChanged(ref _selectedUnitOfQuantityCode, value);
                QuantityUnitCode = _selectedUnitOfQuantityCode?.Code ?? string.Empty;
                RefreshItemCode();
            }
        }
        public IReadOnlyList<CodeInfo> TaxTypes { get; set; }
        public CodeInfo? SelectedTaxType
        {
            get => _selectedTaxType;
            set
            {
                this.RaiseAndSetIfChanged(ref _selectedTaxType, value);
                TaxationTypeCode = _selectedTaxType?.Code ?? string.Empty;
            }
        }

        public SaveItemsViewModel() : base()
        {
            _itemsApiClient = new ItemsApiClient(new HttpApiService(new HttpClient()), new JsonSerializerService());
            _jsonSerializer = new JsonSerializerService();
            SendCommand = ReactiveCommand.Create(Send);
            Nations = CountryCodes.Codes.Select( kv => kv.Value).ToList();
            ProductTypes = ProductTypeCodes.Codes.Select(kv => kv.Value).ToList();
            PackagingUnits = PackagingUnitCodes.Codes.Select(kv => kv.Value).ToList();
            QuantityUnitCodes = UnitOfQuantityCodes.Codes.Select(kv => kv.Value).ToList();
            TaxTypes = TaxTypeCodes.Codes.Select(kv => kv.Value).ToList();
        }

        private async Task Send()
        {
            try
            {
                Response = "Request sending..";
                var response = await _itemsApiClient.SaveItemsAsync(new RwandaVSDC.Models.JSON.Items.SaveItems.SaveItemRequest()
                {
                    Tin = Tin,
                    BranchId = BranchId,
                    ItemCode = ItemCode,
                    ItemClassificationCode = ItemClassificationCode,
                    ItemTypeCode = ItemTypeCode,
                    ItemName = ItemName,
                    ItemStandardName = ItemStandartName,
                    OriginPlaceCode = OriginPlaceCode,
                    PackagingUnitCode = PackagingUnitCode,
                    QuantityUnitCode = QuantityUnitCode,
                    TaxationTypeCode = TaxationTypeCode,
                    BatchNumber = BatchNumber,
                    Barcode = Barcode,
                    DefaultUnitPrice = DefaultUnitPrice,
                    Group1UnitPrice = Group1UnitPrice,
                    Group2UnitPrice = Group2UnitPrice,
                    Group3UnitPrice = Group3UnitPrice,
                    Group4UnitPrice = Group4UnitPrice,
                    Group5UnitPrice = Group5UnitPrice,
                    AdditionalInformation = AdditionalInfo,
                    SaftyQuantity = SaftyQuantity,
                    InsuranceAppicableYesNo = InsuranceAppicableYesNo,
                    UsedYesNo = UsedYesNo,
                    RegistrantID = RegistrantId,
                    RegistrantName = RegistrantName,
                    ModifierID = ModifierId,
                    ModifierName = ModifierName
                });
                Response = _jsonSerializer.Serialize(response) ?? "NullResponse";
                SD.LastRequestDate = response?.ResultDate ?? DateTime.Now.ToString("yyyyMMddHHmmss");

                if (Response.Contains("It is succeeded"))
                {
                    ItemCodeBuilder.Up();
                }
            }
            catch (Exception e)
            {
                Response = e.Message;
            }
        }

        private void RefreshItemCode()
        {
            if (string.IsNullOrEmpty(OriginPlaceCode))
            {
                ItemCode = string.Empty;
                return;
            }
            if (string.IsNullOrEmpty(ItemTypeCode))
            {
                ItemCode = string.Empty;
                return;
            }
            if (string.IsNullOrEmpty(PackagingUnitCode))
            {
                ItemCode = string.Empty;
                return;
            }
            if (string.IsNullOrEmpty(QuantityUnitCode))
            {
                ItemCode = string.Empty;
                return;
            }

            ItemCode = new ItemCodeBuilder().CreateItemCode(OriginPlaceCode, ItemTypeCode, PackagingUnitCode, QuantityUnitCode);
        }
    }
}
