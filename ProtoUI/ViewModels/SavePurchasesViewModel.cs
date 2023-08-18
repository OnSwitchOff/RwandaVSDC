using DynamicData;
using ReactiveUI;
using RwandaVSDC.Services.ApiClients.TransactionsPurchaseApiClient;
using RwandaVSDC.Services.ApiClients.TransactionsSaleApiClient;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProtoUI.ViewModels
{
    public class SavePurchasesViewModel: ViewModelBase
    {
        private readonly ITransactionsPurchaseApiClient _transactionsPurchaseApiClient;
        private readonly IJsonSerializerService _jsonSerializer;

        private string _tin = string.Empty;
        private string _branchId = string.Empty;
        private string _invoiceNumber = string.Empty;
        private string _originalInvoiceNumber = string.Empty;
        private string _supplierTin = string.Empty;
        private string _supplierBranchId = string.Empty;
        private string _supplierName = string.Empty;
        private string _supplierInvoiceNumber = string.Empty;
        private string _supplierSdcId = string.Empty;
        private string _registrationTypeCode = string.Empty;
        private string _purchaseTypeCode = string.Empty;
        private string _receiptTypeCode = string.Empty;
        private string _paymentTypeCode = string.Empty;
        private string _purchaseStatusCode = string.Empty;
        private string _validatedDate = string.Empty;
        private string _purchaseDate = string.Empty;
        private string _warehousingDate = string.Empty;
        private string _cancelReqeuestedDate = string.Empty;
        private string _canceledDate = string.Empty;
        private string _refundedDate = string.Empty;
        private string _totalItemCount = string.Empty;
        private string _taxableAmountA = string.Empty;
        private string _taxableAmountB = string.Empty;
        private string _taxableAmountC = string.Empty;
        private string _taxableAmountD = string.Empty;
        private string _taxRateA = string.Empty;
        private string _taxRateB = string.Empty;
        private string _taxRateC = string.Empty;
        private string _taxRateD = string.Empty;
        private string _taxAmtA = string.Empty;
        private string _taxAmtB = string.Empty;
        private string _taxAmtC = string.Empty;
        private string _taxAmtD = string.Empty;
        private string _totalTaxableAmount = string.Empty;
        private string _totalTaxAmount = string.Empty;
        private string _totalAmount = string.Empty;
        private string _remark = string.Empty;
        private string _registrantName = string.Empty;
        private string _registrantId = string.Empty;
        private string _modifierName = string.Empty;
        private string _modifierId = string.Empty;
        private SavePurchasesItemInfoViewModel? _selectedItem = null;

        private ObservableCollection<SavePurchasesItemInfoViewModel> _itemList = new ObservableCollection<SavePurchasesItemInfoViewModel>();

        private string _response = string.Empty;
        public IReactiveCommand SendCommand { get; }
        public IReactiveCommand AddItemCommand { get; }
        public IReactiveCommand RemoveItemCommand { get; }
        public string Response { get => _response; set => this.RaiseAndSetIfChanged(ref _response, value); }
        public string Tin { get => _tin; set => this.RaiseAndSetIfChanged(ref _tin, value); }
        public string BranchId { get => _branchId; set => this.RaiseAndSetIfChanged(ref _branchId, value); }
        public string InvoiceNumber { get => _invoiceNumber; set => this.RaiseAndSetIfChanged(ref _invoiceNumber, value); }
        public string OriginalInvoiceNumber { get => _originalInvoiceNumber; set => this.RaiseAndSetIfChanged(ref _originalInvoiceNumber, value); }
        public string SupplierTin { get => _supplierTin; set => this.RaiseAndSetIfChanged(ref _supplierTin, value); }
        public string SupplierBranchId { get => _supplierBranchId; set => this.RaiseAndSetIfChanged(ref _supplierBranchId, value); }
        public string SupplierName { get => _supplierName; set => this.RaiseAndSetIfChanged(ref _supplierName, value); }
        public string SupplierInvoiceNumber { get => _supplierInvoiceNumber; set => this.RaiseAndSetIfChanged(ref _supplierInvoiceNumber, value); }
        public string SupplierSdcId { get => _supplierSdcId; set => this.RaiseAndSetIfChanged(ref _supplierSdcId, value); }
        public string RegistrationTypeCode { get => _registrationTypeCode; set => this.RaiseAndSetIfChanged(ref _registrationTypeCode, value); }
        public string PurchaseTypeCode { get => _purchaseTypeCode; set => this.RaiseAndSetIfChanged(ref _purchaseTypeCode, value); }
        public string ReceiptTypeCode { get => _receiptTypeCode; set => this.RaiseAndSetIfChanged(ref _receiptTypeCode, value); }
        public string PaymentTypeCode { get => _paymentTypeCode; set => this.RaiseAndSetIfChanged(ref _paymentTypeCode, value); }
        public string PurchaseStatusCode { get => _purchaseStatusCode; set => this.RaiseAndSetIfChanged(ref _purchaseStatusCode, value); }
        public string ValidatedDate { get => _validatedDate; set => this.RaiseAndSetIfChanged(ref _validatedDate, value); }
        public string PurchaseDate { get => _purchaseDate; set => this.RaiseAndSetIfChanged(ref _purchaseDate, value); }
        public string WarehousingDate { get => _warehousingDate; set => this.RaiseAndSetIfChanged(ref _warehousingDate, value); }
        public string CancelReqeuestedDate { get => _cancelReqeuestedDate; set => this.RaiseAndSetIfChanged(ref _cancelReqeuestedDate, value); }
        public string CanceledDate { get => _canceledDate; set => this.RaiseAndSetIfChanged(ref _canceledDate, value); }
        public string RefundedDate { get => _refundedDate; set => this.RaiseAndSetIfChanged(ref _refundedDate, value); }
        public string TotalItemCount { get => _totalItemCount; set => this.RaiseAndSetIfChanged(ref _totalItemCount, value); }
        public string TaxableAmountA { get => _taxableAmountA; set => this.RaiseAndSetIfChanged(ref _taxableAmountA, value); }
        public string TaxableAmountB { get => _taxableAmountB; set => this.RaiseAndSetIfChanged(ref _taxableAmountB, value); }
        public string TaxableAmountC { get => _taxableAmountC; set => this.RaiseAndSetIfChanged(ref _taxableAmountC, value); }
        public string TaxableAmountD { get => _taxableAmountD; set => this.RaiseAndSetIfChanged(ref _taxableAmountD, value); }
        public string TaxRateA { get => _taxRateA; set => this.RaiseAndSetIfChanged(ref _taxRateA, value); }
        public string TaxRateB { get => _taxRateB; set => this.RaiseAndSetIfChanged(ref _taxRateB, value); }
        public string TaxRateC { get => _taxRateC; set => this.RaiseAndSetIfChanged(ref _taxRateC, value); }
        public string TaxRateD { get => _taxRateD; set => this.RaiseAndSetIfChanged(ref _taxRateD, value); }
        public string TaxAmtA { get => _taxAmtA; set => this.RaiseAndSetIfChanged(ref _taxAmtA, value); }
        public string TaxAmtB { get => _taxAmtB; set => this.RaiseAndSetIfChanged(ref _taxAmtB, value); }
        public string TaxAmtC { get => _taxAmtC; set => this.RaiseAndSetIfChanged(ref _taxAmtC, value); }
        public string TaxAmtD { get => _taxAmtD; set => this.RaiseAndSetIfChanged(ref _taxAmtD, value); }
        public string TotalTaxableAmount { get => _totalTaxableAmount; set => this.RaiseAndSetIfChanged(ref _totalTaxableAmount, value); }
        public string TotalTaxAmount { get => _totalTaxAmount; set => this.RaiseAndSetIfChanged(ref _totalTaxAmount, value); }
        public string TotalAmount { get => _totalAmount; set => this.RaiseAndSetIfChanged(ref _totalAmount, value); }
        public string Remark { get => _remark; set => this.RaiseAndSetIfChanged(ref _remark, value); }
        public string RegistrantName { get => _registrantName; set => this.RaiseAndSetIfChanged(ref _registrantName, value); }
        public string RegistrantId { get => _registrantId; set => this.RaiseAndSetIfChanged(ref _registrantId, value); }
        public string ModifierName { get => _modifierName; set => this.RaiseAndSetIfChanged(ref _modifierName, value); }
        public string ModifierId { get => _modifierId; set => this.RaiseAndSetIfChanged(ref _modifierId, value); }
        public ObservableCollection<SavePurchasesItemInfoViewModel> ItemList { get => _itemList; set => this.RaiseAndSetIfChanged(ref _itemList, value); }
        public SavePurchasesItemInfoViewModel? SelectedItem { get => _selectedItem; set => this.RaiseAndSetIfChanged(ref _selectedItem, value); }

        public SavePurchasesViewModel() : base()
        {
            _transactionsPurchaseApiClient = new TransactionsPurchaseApiClient(new HttpApiService(new HttpClient()), new JsonSerializerService());
            _jsonSerializer = new JsonSerializerService();
            SendCommand = ReactiveCommand.Create(Send);
            AddItemCommand = ReactiveCommand.Create(AddItem);
            RemoveItemCommand = ReactiveCommand.Create(RemoveItem);
        }
        private void RemoveItem()
        {
            if (SelectedItem is not null)
            {
                ItemList.Remove(SelectedItem);
            }
        }

        private void AddItem()
        {
            ItemList.Add(new SavePurchasesItemInfoViewModel());
        }


        private async Task Send()
        {
            try
            {
                Response = "Request sending..";
                throw new NotImplementedException();
                var response = await _transactionsPurchaseApiClient.SavePurchaseAsync(new RwandaVSDC.Models.JSON.TransactionsPurchase.SavePurchases.SavePurchaseRequest());
                Response = _jsonSerializer.Serialize(response) ?? "NullResponse";
                SD.LastRequestDate = response?.ResultDate ?? DateTime.Now.ToString("yyyyMMddHHmmss");
            }
            catch (Exception e)
            {
                Response = e.Message;
            }
        }
    }

    public class SavePurchasesItemInfoViewModel: ViewModelBase
    {
        private string _itemSequenceNumber = string.Empty;
        private string _itemCode = string.Empty;
        private string _itemClassificationCode = string.Empty;
        private string _itemName = string.Empty;
        private string _barcode = string.Empty;
        private string _supplierItemClassificationCode = string.Empty;
        private string _supplierItemCode = string.Empty;
        private string _supplierItemName = string.Empty;
        private string _packagingUnitCode = string.Empty;
        private string _package = string.Empty;
        private string _quantityUnitCode = string.Empty;
        private string _quantity = string.Empty;
        private string _unitPrice = string.Empty;
        private string _supplyAmount = string.Empty;
        private string _discountRate = string.Empty;
        private string _discountAmount = string.Empty;
        private string _taxableAmount = string.Empty;
        private string _taxationTypeCode = string.Empty;
        private string _taxAmount = string.Empty;
        private string _totalAmount = string.Empty;
        private string _itemExpiredDate = string.Empty;

        public SavePurchasesItemInfoViewModel(): base()
        {
            
        }

        public string ItemSequenceNumber { get => _itemSequenceNumber; set => this.RaiseAndSetIfChanged(ref _itemSequenceNumber, value); }
        public string ItemCode { get => _itemCode; set => this.RaiseAndSetIfChanged(ref _itemCode, value); }
        public string ItemClassificationCode { get => _itemClassificationCode; set => this.RaiseAndSetIfChanged(ref _itemClassificationCode, value); }
        public string ItemName { get => _itemName; set => this.RaiseAndSetIfChanged(ref _itemName, value); }
        public string Barcode { get => _barcode; set => this.RaiseAndSetIfChanged(ref _barcode, value); }
        public string SupplierItemClassificationCode { get => _supplierItemClassificationCode; set => this.RaiseAndSetIfChanged(ref _supplierItemClassificationCode, value); }
        public string SupplierItemCode { get => _supplierItemCode; set => this.RaiseAndSetIfChanged(ref _supplierItemCode, value); }
        public string SupplierItemName { get => _supplierItemName; set => this.RaiseAndSetIfChanged(ref _supplierItemName, value); }
        public string PackagingUnitCode { get => _packagingUnitCode; set => this.RaiseAndSetIfChanged(ref _packagingUnitCode, value); }
        public string Package { get => _package; set => this.RaiseAndSetIfChanged(ref _package, value); }
        public string QuantityUnitCode { get => _quantityUnitCode; set => this.RaiseAndSetIfChanged(ref _quantityUnitCode, value); }
        public string Quantity { get => _quantity; set => this.RaiseAndSetIfChanged(ref _quantity, value); }
        public string UnitPrice { get => _unitPrice; set => this.RaiseAndSetIfChanged(ref _unitPrice, value); }
        public string SupplyAmount { get => _supplyAmount; set => this.RaiseAndSetIfChanged(ref _supplyAmount, value); }
        public string DiscountRate { get => _discountRate; set => this.RaiseAndSetIfChanged(ref _discountRate, value); }
        public string DiscountAmount { get => _discountAmount; set => this.RaiseAndSetIfChanged(ref _discountAmount, value); }
        public string TaxableAmount { get => _taxableAmount; set => this.RaiseAndSetIfChanged(ref _taxableAmount, value); }
        public string TaxationTypeCode { get => _taxationTypeCode; set => this.RaiseAndSetIfChanged(ref _taxationTypeCode, value); }
        public string TaxAmount { get => _taxAmount; set => this.RaiseAndSetIfChanged(ref _taxAmount, value); }
        public string TotalAmount { get => _totalAmount; set => this.RaiseAndSetIfChanged(ref _totalAmount, value); }
        public string ItemExpiredDate { get => _itemExpiredDate; set => this.RaiseAndSetIfChanged(ref _itemExpiredDate, value); }
    }
}
