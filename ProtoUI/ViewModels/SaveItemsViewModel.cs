using ReactiveUI;
using RwandaVSDC.Models.Data;
using RwandaVSDC.Models.Enums;
using RwandaVSDC.Services.ApiClients.BranchesApiClient;
using RwandaVSDC.Services.ApiClients.ItemsApiClient;
using RwandaVSDC.Services.ApiService;
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

        private string _tin = string.Empty;
        private string _branchId = string.Empty;
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
        private string _batchNumber = string.Empty;
        private string _barcode = string.Empty;
        private string _defaultUnitPrice = string.Empty;
        private string _group1UnitPrice = string.Empty;
        private string _group2UnitPrice = string.Empty;
        private string _group3UnitPrice = string.Empty;
        private string _group4UnitPrice = string.Empty;
        private string _group5UnitPrice = string.Empty;
        private string _additionalInfo = string.Empty;
        private string _saftyQuantity = string.Empty;
        private string _insuranceAppicableYesNo = string.Empty;
        private string _usedYesNo = string.Empty;
        private string _registrantName = string.Empty;
        private string _registrantId = string.Empty;
        private string _modifierName = string.Empty;
        private string _modifierId = string.Empty;


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
        public string DefaultUnitPrice { get => _defaultUnitPrice; set => this.RaiseAndSetIfChanged(ref _defaultUnitPrice, value); }
        public string Group1UnitPrice { get => _group1UnitPrice; set => this.RaiseAndSetIfChanged(ref _group1UnitPrice, value); }
        public string Group2UnitPrice { get => _group2UnitPrice; set => this.RaiseAndSetIfChanged(ref _group2UnitPrice, value); }
        public string Group3UnitPrice { get => _group3UnitPrice; set => this.RaiseAndSetIfChanged(ref _group3UnitPrice, value); }
        public string Group4UnitPrice { get => _group4UnitPrice; set => this.RaiseAndSetIfChanged(ref _group4UnitPrice, value); }
        public string Group5UnitPrice { get => _group5UnitPrice; set => this.RaiseAndSetIfChanged(ref _group5UnitPrice, value); }
        public string AdditionalInfo { get => _additionalInfo; set => this.RaiseAndSetIfChanged(ref _additionalInfo, value); }
        public string SaftyQuantity { get => _saftyQuantity; set => this.RaiseAndSetIfChanged(ref _saftyQuantity, value); }
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
            }
        }

        public SaveItemsViewModel() : base()
        {
            _itemsApiClient = new ItemsApiClient(new HttpApiService(new HttpClient()), new JsonSerializerService());
            SendCommand = ReactiveCommand.Create(Send);
            Nations = CountryCodes.Codes.Select( kv => kv.Value).ToList();
            ProductTypes = ProductTypeCodes.Codes.Select(kv => kv.Value).ToList();
            PackagingUnits = PackagingUnitCodes.Codes.Select(kv => kv.Value).ToList();
            QuantityUnitCodes = UnitOfQuantityCodes.Codes.Select(kv => kv.Value).ToList();
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
