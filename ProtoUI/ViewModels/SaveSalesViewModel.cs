using ReactiveUI;
using RwandaVSDC.Services.ApiClients.ItemsApiClient;
using RwandaVSDC.Services.ApiClients.TransactionsSaleApiClient;
using RwandaVSDC.Services.ApiService;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Reactive.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProtoUI.ViewModels
{
    public class SaveSalesViewModel: ViewModelBase
    {
        private readonly ITransactionsSaleApiClient _transactionsSaleApiClient;

        private string _tin = string.Empty;
        private string _branchId = string.Empty;
        private string _invoiceNumber = string.Empty;
        private string _originalInvoiceNumber = string.Empty;
        private string _customerTin = string.Empty;
        private string _customerName = string.Empty;
        private string _salesTypeCode = string.Empty;
        private string _receiptTypeCode = string.Empty;
        private string _paymentTypeCode = string.Empty;
        private string _invoiceStatusCode = string.Empty;
        private string _validateDate = string.Empty;
        private string _saleDate = string.Empty;
        private string _stockReleasedDate = string.Empty;
        private string _cancelRequestedDate = string.Empty;
        private string _canceledDate = string.Empty;
        private string _refundedDate = string.Empty;
        private string _refundedReasoneCode = string.Empty;
        private string _totalItemCount = string.Empty;
        private string _taxableAmountA = string.Empty;
        private string _taxableAmountB = string.Empty;
        private string _taxableAmountC = string.Empty;
        private string _taxableAmountD = string.Empty;
        private string _taxableRateA = string.Empty;
        private string _taxableRateB = string.Empty;
        private string _taxableRateC = string.Empty;
        private string _taxableRateD = string.Empty;
        private string _taxAmountA = string.Empty;
        private string _taxAmountB = string.Empty;
        private string _taxAmountC = string.Empty;
        private string _taxAmountD = string.Empty;
        private string _totalTaxableAmount = string.Empty;
        private string _totalTaxAmount = string.Empty;
        private string _totalAmount = string.Empty;
        private string _purchaseAcceptYesNo = string.Empty;
        private string _remark = string.Empty;
        private string _registrantName = string.Empty;
        private string _registrantId = string.Empty;
        private string _modifierName = string.Empty;
        private string _modifierId = string.Empty;
        private SaveSalesReceiptViewModel _receipt = new SaveSalesReceiptViewModel();
        private ObservableCollection<SaveSaleItemInfoViewModel> _itemList = new ObservableCollection<SaveSaleItemInfoViewModel>()
        {
            new SaveSaleItemInfoViewModel(),
            new SaveSaleItemInfoViewModel(),
            new SaveSaleItemInfoViewModel()
        };


        private string _response = string.Empty;

        public IReactiveCommand SendCommand { get; }
        public string Tin { get => _tin; set => this.RaiseAndSetIfChanged(ref _tin, value); }
        public string BranchId { get => _branchId; set => this.RaiseAndSetIfChanged(ref _branchId, value); }
        public string InvoiceNumber { get => _invoiceNumber; set => this.RaiseAndSetIfChanged(ref _invoiceNumber, value); }
        public string OriginalInvoiceNumber { get => _originalInvoiceNumber; set => this.RaiseAndSetIfChanged(ref _originalInvoiceNumber, value); }
        public string CustomerTin { get => _customerTin; set => this.RaiseAndSetIfChanged(ref _customerTin, value); }
        public string CustomerName { get => _customerName; set => this.RaiseAndSetIfChanged(ref _customerName, value); }
        public string SalesTypeCode { get => _salesTypeCode; set => this.RaiseAndSetIfChanged(ref _salesTypeCode, value); }
        public string ReceiptTypeCode { get => _receiptTypeCode; set => this.RaiseAndSetIfChanged(ref _receiptTypeCode, value); }
        public string PaymentTypeCode { get => _paymentTypeCode; set => this.RaiseAndSetIfChanged(ref _paymentTypeCode, value); }
        public string InvoiceStatusCode { get => _invoiceStatusCode; set => this.RaiseAndSetIfChanged(ref _invoiceStatusCode, value); }
        public string ValidateDate { get => _validateDate; set => this.RaiseAndSetIfChanged(ref _validateDate, value); }
        public string SaleDate { get => _saleDate; set => this.RaiseAndSetIfChanged(ref _saleDate, value); }
        public string StockReleasedDate { get => _stockReleasedDate; set => this.RaiseAndSetIfChanged(ref _stockReleasedDate, value); }
        public string CancelRequestedDate { get => _cancelRequestedDate; set => this.RaiseAndSetIfChanged(ref _cancelRequestedDate, value); }
        public string CanceledDate { get => _canceledDate; set => this.RaiseAndSetIfChanged(ref _canceledDate, value); }
        public string RefundedDate { get => _refundedDate; set => this.RaiseAndSetIfChanged(ref _refundedDate, value); }
        public string RefundedReasoneCode { get => _refundedReasoneCode; set => this.RaiseAndSetIfChanged(ref _refundedReasoneCode, value); }
        public string TotalItemCount { get => _totalItemCount; set => this.RaiseAndSetIfChanged(ref _totalItemCount, value); }
        public string TaxableAmountA { get => _taxableAmountA; set => this.RaiseAndSetIfChanged(ref _taxableAmountA, value); }
        public string TaxableAmountB { get => _taxableAmountB; set => this.RaiseAndSetIfChanged(ref _taxableAmountB, value); }
        public string TaxableAmountC { get => _taxableAmountC; set => this.RaiseAndSetIfChanged(ref _taxableAmountC, value); }
        public string TaxableAmountD { get => _taxableAmountD; set => this.RaiseAndSetIfChanged(ref _taxableAmountD, value); }
        public string TaxableRateA { get => _taxableRateA; set => this.RaiseAndSetIfChanged(ref _taxableRateA, value); }
        public string TaxableRateB { get => _taxableRateB; set => this.RaiseAndSetIfChanged(ref _taxableRateB, value); }
        public string TaxableRateC { get => _taxableRateC; set => this.RaiseAndSetIfChanged(ref _taxableRateC, value); }
        public string TaxableRateD { get => _taxableRateD; set => this.RaiseAndSetIfChanged(ref _taxableRateD, value); }
        public string TaxAmountA { get => _taxAmountA; set => this.RaiseAndSetIfChanged(ref _taxAmountA, value); }
        public string TaxAmountB { get => _taxAmountB; set => this.RaiseAndSetIfChanged(ref _taxAmountB, value); }
        public string TaxAmountC { get => _taxAmountC; set => this.RaiseAndSetIfChanged(ref _taxAmountC, value); }
        public string TaxAmountD { get => _taxAmountD; set => this.RaiseAndSetIfChanged(ref _taxAmountD, value); }
        public string TotalTaxableAmount { get => _totalTaxableAmount; set => this.RaiseAndSetIfChanged(ref _totalTaxableAmount, value); }
        public string TotalTaxAmount { get => _totalTaxAmount; set => this.RaiseAndSetIfChanged(ref _totalTaxAmount, value); }
        public string TotalAmount { get => _totalAmount; set => this.RaiseAndSetIfChanged(ref _totalAmount, value); }
        public string PurchaseAcceptYesNo { get => _purchaseAcceptYesNo; set => this.RaiseAndSetIfChanged(ref _purchaseAcceptYesNo, value); }
        public string Remark { get => _remark; set => this.RaiseAndSetIfChanged(ref _remark, value); }
        public string RegistrantName { get => _registrantName; set => this.RaiseAndSetIfChanged(ref _registrantName, value); }
        public string RegistrantId { get => _registrantId; set => this.RaiseAndSetIfChanged(ref _registrantId, value); }
        public string ModifierName { get => _modifierName; set => this.RaiseAndSetIfChanged(ref _modifierName, value); }
        public string ModifierId { get => _modifierId; set => this.RaiseAndSetIfChanged(ref _modifierId, value); }
        public string Response { get => _response; set => this.RaiseAndSetIfChanged(ref _response, value); }
        public SaveSalesReceiptViewModel Receipt { get => _receipt; set => this.RaiseAndSetIfChanged(ref _receipt, value); }
        public ObservableCollection<SaveSaleItemInfoViewModel> ItemList
        { 
            get => _itemList;
            set => this.RaiseAndSetIfChanged(ref _itemList, value); 
        }

        public SaveSalesViewModel() : base()
        {
            _transactionsSaleApiClient = new TransactionsSaleApiClient(new HttpApiService(new HttpClient()), new JsonSerializerService());
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

    public class SaveSalesReceiptViewModel: ViewModelBase
    {
        private string _customerTin = string.Empty;
        private string _customerMobileNumber = string.Empty;
        private string _reportNumber = string.Empty;
        private string _tradeName = string.Empty;
        private string _address = string.Empty;
        private string _topMessage = string.Empty;
        private string _bottomMessage = string.Empty;
        private string _buyersReceiveItemYesNo = string.Empty;

        public string CustomerTin { get => _customerTin; set => this.RaiseAndSetIfChanged(ref _customerTin, value); }
        public string CustomerMobileNumber { get => _customerMobileNumber; set => this.RaiseAndSetIfChanged(ref _customerMobileNumber, value); }
        public string ReportNumber { get => _reportNumber; set => this.RaiseAndSetIfChanged(ref _reportNumber, value); }
        public string TradeName { get => _tradeName; set => this.RaiseAndSetIfChanged(ref _tradeName, value); }
        public string Address { get => _address; set => this.RaiseAndSetIfChanged(ref _address, value); }
        public string TopMessage { get => _topMessage; set => this.RaiseAndSetIfChanged(ref _topMessage, value); }
        public string BottomMessage { get => _bottomMessage; set => this.RaiseAndSetIfChanged(ref _bottomMessage, value); }
        public string BuyersReceiveItemYesNo { get => _buyersReceiveItemYesNo; set => this.RaiseAndSetIfChanged(ref _buyersReceiveItemYesNo, value); }

        public SaveSalesReceiptViewModel()
        {
            
        }
    }

    public class SaveSaleItemInfoViewModel : ViewModelBase
    {
        private string _itemSequenceNumber = string.Empty;
        private string _itemCode = string.Empty;
        private string _itemClassificationCode = string.Empty;
        private string _itemName = string.Empty;
        private string _barcode = string.Empty;
        private string _packagingUnitCode = string.Empty;
        private string _package = string.Empty;
        private string _quantityUnitCode = string.Empty;
        private string _quantity = string.Empty;
        private string _unitPrice = string.Empty;
        private string _supplyAmount = string.Empty;
        private string _discountRate = string.Empty;
        private string _discountAmount = string.Empty;
        private string _insuranceCompanyCode = string.Empty;
        private string _insuranceCompanyName = string.Empty;
        private string _insuranceRate = string.Empty;
        private string _insuranceAmount = string.Empty;
        private string _taxationTypeCode = string.Empty;
        private string _taxableAmount = string.Empty;
        private string _taxAmount = string.Empty;
        private string _totalAmount = string.Empty;

        public SaveSaleItemInfoViewModel()
        {

        }

        public string ItemSequenceNumber { get => _itemSequenceNumber; set => this.RaiseAndSetIfChanged(ref _itemSequenceNumber, value); }
        public string ItemCode { get => _itemCode; set => this.RaiseAndSetIfChanged(ref _itemCode, value); }
        public string ItemClassificationCode { get => _itemClassificationCode; set => this.RaiseAndSetIfChanged(ref _itemClassificationCode, value); }
        public string ItemName { get => _itemName; set => this.RaiseAndSetIfChanged(ref _itemName, value); }
        public string Barcode { get => _barcode; set => this.RaiseAndSetIfChanged(ref _barcode, value); }
        public string PackagingUnitCode { get => _packagingUnitCode; set => this.RaiseAndSetIfChanged(ref _packagingUnitCode, value); }
        public string Package { get => _package; set => this.RaiseAndSetIfChanged(ref _package, value); }
        public string QuantityUnitCode { get => _quantityUnitCode; set => this.RaiseAndSetIfChanged(ref _quantityUnitCode, value); }
        public string Quantity { get => _quantity; set => this.RaiseAndSetIfChanged(ref _quantity, value); }
        public string UnitPrice { get => _unitPrice; set => this.RaiseAndSetIfChanged(ref _unitPrice, value); }
        public string SupplyAmount { get => _supplyAmount; set => this.RaiseAndSetIfChanged(ref _supplyAmount, value); }
        public string DiscountRate { get => _discountRate; set => this.RaiseAndSetIfChanged(ref _discountRate, value); }
        public string DiscountAmount { get => _discountAmount; set => this.RaiseAndSetIfChanged(ref _discountAmount, value); }
        public string InsuranceCompanyCode { get => _insuranceCompanyCode; set => this.RaiseAndSetIfChanged(ref _insuranceCompanyCode, value); }
        public string InsuranceCompanyName { get => _insuranceCompanyName; set => this.RaiseAndSetIfChanged(ref _insuranceCompanyName, value); }
        public string InsuranceRate { get => _insuranceRate; set => this.RaiseAndSetIfChanged(ref _insuranceRate, value); }
        public string InsuranceAmount { get => _insuranceAmount; set => this.RaiseAndSetIfChanged(ref _insuranceAmount, value); }
        public string TaxationTypeCode { get => _taxationTypeCode; set => this.RaiseAndSetIfChanged(ref _taxationTypeCode, value); }
        public string TaxableAmount { get => _taxableAmount; set => this.RaiseAndSetIfChanged(ref _taxableAmount, value); }
        public string TaxAmount { get => _taxAmount; set => this.RaiseAndSetIfChanged(ref _taxAmount, value); }
        public string TotalAmount { get => _totalAmount; set => this.RaiseAndSetIfChanged(ref _totalAmount, value); }
    }
}
