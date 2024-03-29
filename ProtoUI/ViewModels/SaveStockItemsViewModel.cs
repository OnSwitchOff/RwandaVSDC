﻿using DynamicData;
using ReactiveUI;
using RwandaVSDC.Services.ApiClients.StockApiClient;
using RwandaVSDC.Services.ApiClients.TransactionsPurchaseApiClient;
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
    public class SaveStockItemsViewModel : ViewModelBase
    {
        private readonly IStockApiClient _stockApiClient;
        private readonly IJsonSerializerService _jsonSerializer;

        private string _tin = string.Empty;
        private string _branchId = string.Empty;
        private string _storedAndReleasedNumber = string.Empty;
        private string _originalStoredAndReleasedNumber = string.Empty;
        private string _registrationTypeCode = string.Empty;
        private string _customerTin = string.Empty;
        private string _customerName = string.Empty;
        private string _customerBranchOfficeId = string.Empty;
        private string _storedAndReleasedTypeCode = string.Empty;
        private string _occurredDate = string.Empty;
        private string _totalItemCount = string.Empty;
        private string _totalTaxableAmount = string.Empty;
        private string _totalTaxAmount = string.Empty;
        private string _totalAmount = string.Empty;
        private string _remark = string.Empty;
        private string _registrantName = string.Empty;
        private string _registrantId = string.Empty;
        private string _modifierName = string.Empty;
        private string _modifierId = string.Empty;
        private SaveStockItemsItemInfoViewModel? _selectedItem = null;
        private ObservableCollection<SaveStockItemsItemInfoViewModel> _itemList = new ObservableCollection<SaveStockItemsItemInfoViewModel>();
        private SaveStockItemsItemInfoViewModel? _editingItem = null;
        private bool _isEditPanelVisible = false;

        private string _response = string.Empty;
        public IReactiveCommand SendCommand { get; }
        public IReactiveCommand AddItemCommand { get; }
        public IReactiveCommand EditItemCommand { get; }
        public IReactiveCommand RemoveItemCommand { get; }
        public IReactiveCommand ConfirmChangesCommand { get; }
        public IReactiveCommand DiscardChangesCommand { get; }
        public string Tin { get => _tin; set => this.RaiseAndSetIfChanged(ref _tin, value); }
        public string BranchId { get => _branchId; set => this.RaiseAndSetIfChanged(ref _branchId, value); }
        public string StoredAndReleasedNumber { get => _storedAndReleasedNumber; set => this.RaiseAndSetIfChanged(ref _storedAndReleasedNumber, value); }
        public string OriginalStoredAndReleasedNumber { get => _originalStoredAndReleasedNumber; set => this.RaiseAndSetIfChanged(ref _originalStoredAndReleasedNumber, value); }
        public string RegistrationTypeCode { get => _registrationTypeCode; set => this.RaiseAndSetIfChanged(ref _registrationTypeCode, value); }
        public string CustomerTin { get => _customerTin; set => this.RaiseAndSetIfChanged(ref _customerTin, value); }
        public string CustomerName { get => _customerName; set => this.RaiseAndSetIfChanged(ref _customerName, value); }
        public string CustomerBranchOfficeId { get => _customerBranchOfficeId; set => this.RaiseAndSetIfChanged(ref _customerBranchOfficeId, value); }
        public string StoredAndReleasedTypeCode { get => _storedAndReleasedTypeCode; set => this.RaiseAndSetIfChanged(ref _storedAndReleasedTypeCode, value); }
        public string OccurredDate { get => _occurredDate; set => this.RaiseAndSetIfChanged(ref _occurredDate, value); }
        public string TotalItemCount { get => _totalItemCount; set => this.RaiseAndSetIfChanged(ref _totalItemCount, value); }
        public string TotalTaxableAmount { get => _totalTaxableAmount; set => this.RaiseAndSetIfChanged(ref _totalTaxableAmount, value); }
        public string TotalTaxAmount { get => _totalTaxAmount; set => this.RaiseAndSetIfChanged(ref _totalTaxAmount, value); }
        public string TotalAmount { get => _totalAmount; set => this.RaiseAndSetIfChanged(ref _totalAmount, value); }
        public string Remark { get => _remark; set => this.RaiseAndSetIfChanged(ref _remark, value); }
        public string RegistrantName { get => _registrantName; set => this.RaiseAndSetIfChanged(ref _registrantName, value); }
        public string RegistrantId { get => _registrantId; set => this.RaiseAndSetIfChanged(ref _registrantId, value); }
        public string ModifierName { get => _modifierName; set => this.RaiseAndSetIfChanged(ref _modifierName, value); }
        public string ModifierId { get => _modifierId; set => this.RaiseAndSetIfChanged(ref _modifierId, value); }
        public string Response { get => _response; set => this.RaiseAndSetIfChanged(ref _response, value); }
        public SaveStockItemsItemInfoViewModel? SelectedItem { get => _selectedItem;
            set
            {
                if (IsEditPanelVisible)
                {
                    value = _selectedItem;
                }
                this.RaiseAndSetIfChanged(ref _selectedItem, value);
            }
        }
        public ObservableCollection<SaveStockItemsItemInfoViewModel> ItemList { get => _itemList; set => this.RaiseAndSetIfChanged(ref _itemList, value); }
        public SaveStockItemsItemInfoViewModel? EditingItem { get => _editingItem; set => this.RaiseAndSetIfChanged(ref _editingItem, value); }
        public bool IsEditPanelVisible { get => _isEditPanelVisible; set => this.RaiseAndSetIfChanged(ref _isEditPanelVisible, value); }

        public SaveStockItemsViewModel() : base()
        {
            _stockApiClient = new StockApiClient(new HttpApiService(new HttpClient()), new JsonSerializerService());
            _jsonSerializer = new JsonSerializerService();
            SendCommand = ReactiveCommand.Create(Send);
            AddItemCommand = ReactiveCommand.Create(AddItem);
            EditItemCommand = ReactiveCommand.Create(EditItem);
            RemoveItemCommand = ReactiveCommand.Create(RemoveItem);
            ConfirmChangesCommand = ReactiveCommand.Create(ConfirmChanges);
            DiscardChangesCommand = ReactiveCommand.Create(DiscardChanges);
        }

        private void DiscardChanges()
        {
            EditingItem = null;
            IsEditPanelVisible = false;
        }

        private void ConfirmChanges()
        {
            if (SelectedItem is null)
            {
                ItemList.Add(new SaveStockItemsItemInfoViewModel
                {
                    ItemSequence = EditingItem!.ItemSequence,
                    ItemCode = EditingItem.ItemCode,
                    ItemClassificationCode = EditingItem.ItemClassificationCode,
                    ItemName = EditingItem.ItemName,
                    Barcode = EditingItem.Barcode,
                    PackageQuantity = EditingItem.PackageQuantity,
                    PackagingUnitCode = EditingItem.PackagingUnitCode,
                    QuantityUnitCode = EditingItem.QuantityUnitCode,
                    UnitQuantity = EditingItem.UnitQuantity,
                    ItemExpiredDate = EditingItem.ItemExpiredDate,
                    UnitPrice = EditingItem.UnitPrice,
                    SupplyAmount = EditingItem.SupplyAmount,
                    DiscountAmount = EditingItem.DiscountAmount,
                    TaxableAmount = EditingItem.TaxableAmount,
                    TotalAmount = EditingItem.TotalAmount,
                    TaxationTypeCode = EditingItem.TaxationTypeCode,
                    TaxAmount = EditingItem.TaxAmount
                });
            }
            else
            {
                SelectedItem.ItemSequence = EditingItem!.ItemSequence;
                SelectedItem.ItemCode = EditingItem.ItemCode;
                SelectedItem.ItemClassificationCode = EditingItem.ItemClassificationCode;
                SelectedItem.ItemName = EditingItem.ItemName;
                SelectedItem.Barcode = EditingItem.Barcode;
                SelectedItem.PackageQuantity = EditingItem.PackageQuantity;
                SelectedItem.PackagingUnitCode = EditingItem.PackagingUnitCode;
                SelectedItem.QuantityUnitCode = EditingItem.QuantityUnitCode;
                SelectedItem.UnitQuantity = EditingItem.UnitQuantity;
                SelectedItem.ItemExpiredDate = EditingItem.ItemExpiredDate;
                SelectedItem.UnitPrice = EditingItem.UnitPrice;
                SelectedItem.SupplyAmount = EditingItem.SupplyAmount;
                SelectedItem.DiscountAmount = EditingItem.DiscountAmount;
                SelectedItem.TaxableAmount = EditingItem.TaxableAmount;
                SelectedItem.TotalAmount = EditingItem.TotalAmount;
                SelectedItem.TaxationTypeCode = EditingItem.TaxationTypeCode;
                SelectedItem.TaxAmount = EditingItem.TaxAmount;
            }
            EditingItem = null;
            IsEditPanelVisible = false;
        }

        private void RemoveItem()
        {
            if (SelectedItem is not null)
            {
                ItemList.Remove(SelectedItem);
            }
        }

        private void EditItem()
        {
            if (SelectedItem is not null)
            {
                EditingItem = new SaveStockItemsItemInfoViewModel
                {
                    ItemSequence = SelectedItem.ItemSequence,
                    ItemCode = SelectedItem.ItemCode,
                    ItemClassificationCode = SelectedItem.ItemClassificationCode,
                    ItemName = SelectedItem.ItemName,
                    Barcode = SelectedItem.Barcode,
                    PackageQuantity = SelectedItem.PackageQuantity,
                    PackagingUnitCode = SelectedItem.PackagingUnitCode,
                    QuantityUnitCode = SelectedItem.QuantityUnitCode,
                    UnitQuantity = SelectedItem.UnitQuantity,
                    ItemExpiredDate = SelectedItem.ItemExpiredDate,
                    UnitPrice = SelectedItem.UnitPrice,
                    SupplyAmount = SelectedItem.SupplyAmount,
                    DiscountAmount = SelectedItem.DiscountAmount,
                    TaxableAmount = SelectedItem.TaxableAmount,
                    TotalAmount = SelectedItem.TotalAmount,
                    TaxationTypeCode = SelectedItem.TaxationTypeCode,
                    TaxAmount = SelectedItem.TaxAmount
                };
                IsEditPanelVisible = true;
            }
        }

        private void AddItem()
        {
            SelectedItem = null;
            EditingItem = new SaveStockItemsItemInfoViewModel();
            IsEditPanelVisible = true;
        }

        private async Task Send()
        {
            try
            {
                Response = "Request sending..";
                await Task.Delay(1000);
                throw new NotImplementedException();
                var response = await _stockApiClient.SaveStockItemsAsync(new RwandaVSDC.Models.JSON.Stock.SaveStockItems.SaveStockRequest());
                Response = _jsonSerializer.Serialize(response) ?? "NullResponse";
                SD.LastRequestDate = response?.ResultDate ?? DateTime.Now.ToString("yyyyMMddHHmmss");
            }
            catch (Exception e)
            {
                Response = e.Message;
            }
        }
    }

    public class SaveStockItemsItemInfoViewModel: ViewModelBase
    {
        private string _itemSequence = string.Empty;
        private string _itemCode = string.Empty;
        private string _itemClassificationCode = string.Empty;
        private string _itemName = string.Empty;
        private string _barcode = string.Empty;
        private string _packagingUnitCode = string.Empty;
        private string _packageQuantity = string.Empty;
        private string _quantityUnitCode = string.Empty;
        private string _unitQuantity = string.Empty;
        private string _itemExpiredDate = string.Empty;
        private string _unitPrice = string.Empty;
        private string _supplyAmount = string.Empty;
        private string _discountAmount = string.Empty;
        private string _taxableAmount = string.Empty;
        private string _taxationTypeCode = string.Empty;
        private string _taxAmount = string.Empty;
        private string _totalAmount = string.Empty;

        public SaveStockItemsItemInfoViewModel() : base() {}

        public string ItemSequence { get => _itemSequence; set => this.RaiseAndSetIfChanged(ref _itemSequence, value); }
        public string ItemCode { get => _itemCode; set => this.RaiseAndSetIfChanged(ref _itemCode, value); }
        public string ItemClassificationCode { get => _itemClassificationCode; set => this.RaiseAndSetIfChanged(ref _itemClassificationCode, value); }
        public string ItemName { get => _itemName; set => this.RaiseAndSetIfChanged(ref _itemName, value); }
        public string Barcode { get => _barcode; set => this.RaiseAndSetIfChanged(ref _barcode, value); }
        public string PackagingUnitCode { get => _packagingUnitCode; set => this.RaiseAndSetIfChanged(ref _packagingUnitCode, value); }
        public string PackageQuantity { get => _packageQuantity; set => this.RaiseAndSetIfChanged(ref _packageQuantity, value); }
        public string QuantityUnitCode { get => _quantityUnitCode; set => this.RaiseAndSetIfChanged(ref _quantityUnitCode, value); }
        public string UnitQuantity { get => _unitQuantity; set => this.RaiseAndSetIfChanged(ref _unitQuantity, value); }
        public string ItemExpiredDate { get => _itemExpiredDate; set => this.RaiseAndSetIfChanged(ref _itemExpiredDate, value); }
        public string UnitPrice { get => _unitPrice; set => this.RaiseAndSetIfChanged(ref _unitPrice, value); }
        public string SupplyAmount { get => _supplyAmount; set => this.RaiseAndSetIfChanged(ref _supplyAmount, value); }
        public string DiscountAmount { get => _discountAmount; set => this.RaiseAndSetIfChanged(ref _discountAmount, value); }
        public string TaxableAmount { get => _taxableAmount; set => this.RaiseAndSetIfChanged(ref _taxableAmount, value); }
        public string TaxationTypeCode { get => _taxationTypeCode; set => this.RaiseAndSetIfChanged(ref _taxationTypeCode, value); }
        public string TaxAmount { get => _taxAmount; set => this.RaiseAndSetIfChanged(ref _taxAmount, value); }
        public string TotalAmount { get => _totalAmount; set => this.RaiseAndSetIfChanged(ref _totalAmount, value); }
    }
}
