using FluentAssertions;
using RwandaVSDC.Models.JSON.Items.SelectItems;
using RwandaVSDC.Models.JSON.TransactionsSales.SaveSales;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.JSON.TransactionsSales.SaveSales
{
    public class SaveSaleRequestTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"tin\":\"999999991\",\"bhfId\":\"00\",\"invcNo\":15,\"orgInvcNo\":0,\"custTin\":\"999999992\",\"custNm\":\"RRA\",\"salesTyCd\":\"N\",\"rcptTyCd\":\"S\",\"pmtTyCd\":\"01\",\"salesSttsCd\":\"02\",\"cfmDt\":\"20210709120300\",\"salesDt\":\"20210709\",\"stockRlsDt\":\"20210709120300\",\"cnclReqDt\":null,\"cnclDt\":null,\"rfdDt\":null,\"rfdRsnCd\":null,\"totItemCnt\":2,\"taxblAmtA\":0,\"taxblAmtB\":250000,\"taxblAmtC\":0,\"taxblAmtD\":0,\"taxRtA\":0,\"taxRtB\":18,\"taxRtC\":0,\"taxRtD\":0,\"taxAmtA\":0,\"taxAmtB\":94576,\"taxAmtC\":0,\"taxAmtD\":0,\"totTaxblAmt\":250000,\"totTaxAmt\":38135,\"totAmt\":250000,\"prchrAcptcYn\":\"N\",\"remark\":null,\"regrId\":\"11999\",\"regrNm\":\"Test VSDC\",\"modrId\":\"45678\",\"modrNm\":\"TestVSDC\",\"receipt\":{\"custTin\":\"100110263\",\"custMblNo\":null,\"rptNo\":1,\"trdeNm\":\"\",\"adrs\":\"\",\"topMsg\":\"Shopwithus\",\"btmMsg\":\"Welcome\",\"prchrAcptcYn\":\"N\"},\"itemList\":[{\"itemSeq\":1,\"itemCd\":\"RW1NTXU0000001\",\"itemClsCd\":\"5059690800\",\"itemNm\":\"OutDoorUnit\",\"bcd\":null,\"pkgUnitCd\":\"NT\",\"pkg\":1,\"qtyUnitCd\":\"U\",\"qty\":1,\"prc\":200000,\"splyAmt\":200000,\"dcRt\":0,\"dcAmt\":0,\"isrccCd\":null,\"isrccNm\":null,\"isrcRt\":null,\"isrcAmt\":null,\"taxTyCd\":\"B\",\"taxblAmt\":200000,\"taxAmt\":30508,\"totAmt\":200000},{\"itemSeq\":2,\"itemCd\":\"RW1NTXU0000002\",\"itemClsCd\":\"5022110801\",\"itemNm\":\"Networ kCable\",\"bcd\":null,\"pkgUnitCd\":\"NT\",\"pkg\":1,\"qtyUnitCd\":\"U\",\"qty\":1,\"prc\":50000,\"splyAmt\":50000,\"dcRt\":0,\"dcAmt\":0,\"isrccCd\":null,\"isrccNm\":null,\"isrcRt\":null,\"isrcAmt\":null,\"taxTyCd\":\"B\",\"taxblAmt\":50000,\"taxAmt\":7627,\"totAmt\":50000}]}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            SaveSalesRequest testObject = new SaveSalesRequest
            {
                Tin = "999999991",
                BranchId = "00",
                ValidatedDate = "20210709120300",
                CanceledDate = null,
                CancelReqeuestedDate = null,
                CustomerName = "RRA",
                CustomerTin = "999999992",
                InvoiceNumber = 15,
                ItemList = new List<SaveSaleRequestItemInfo>
                {
                    new SaveSaleRequestItemInfo
                    {
                        Barcode = null,
                        DiscountAmount = 0,
                        DiscountRate = 0,
                        InsuranceCompanyCode = null,
                        InsuranceAmount = null,
                        InsuranceRate = null,
                        InsuranceCompanyName = null,
                        ItemCode = "RW1NTXU0000001",
                        ItemClassificationCode = "5059690800",
                        ItemName = "OutDoorUnit",
                        ItemSequenceNumber = 1,
                        Package = 1,
                        PackagingUnitCode = "NT",
                        UnitPrice = 200000,
                        Quantity = 1,
                        QuantityUnitCode = "U",
                        SupplyAmount = 200000,
                        TaxAmount = 30508,
                        TaxationTypeCode = "B",
                        TaxableAmount = 200000,
                        TotalAmount = 200000
                    },
                     new SaveSaleRequestItemInfo
                    {
                        Barcode = null,
                        DiscountAmount = 0,
                        DiscountRate = 0,
                        InsuranceCompanyCode = null,
                        InsuranceAmount = null,
                        InsuranceRate = null,
                        InsuranceCompanyName = null,
                        ItemCode = "RW1NTXU0000002",
                        ItemClassificationCode = "5022110801",
                        ItemName = "Networ kCable",
                        ItemSequenceNumber = 2,
                        Package = 1,
                        PackagingUnitCode = "NT",
                        UnitPrice = 50000,
                        Quantity = 1,
                        QuantityUnitCode = "U",
                        SupplyAmount = 50000,
                        TaxAmount = 7627,
                        TaxationTypeCode = "B",
                        TaxableAmount = 50000,
                        TotalAmount = 50000
                    }
                },
                ModifierId = "45678",
                ModifierName = "TestVSDC",
                OriginalInvoiceNumber = 0,
                PaymentTypeCode = "01",
                PurchaseAcceptYesNo = "N",
                ReceiptTypeCode = "S",
                Receipt = new SaveSaleRequestReceipt
                {
                    Address = "",
                    BottomMessage = "Welcome",
                    CustomerMobileNumber = null,
                    CustomerTin = "100110263",
                    BuyersReceiveItemYesNo = "N",
                    ReportNumber = 1,
                    TopMessage = "Shopwithus",
                    TradeName = "",
                },
                RegistrantId = "11999",
                RegistrantName = "Test VSDC",
                Remark = null,
                RefundedDate = null,
                RefundedReasonCode = null,
                SaleDate = "20210709",
                InvoiceStatusCode = "02",
                SalesTypeCode = "N",
                StockReleasedDate = "20210709120300",
                TaxRateD = 0,
                TaxAmtA = 0,
                TaxAmtB = 94576,
                TaxAmtC = 0,
                TaxAmtD = 0,
                TaxRateA = 0,
                TaxRateB = 18,
                TaxRateC = 0,
                TaxableAmountA = 0,
                TaxableAmountB = 250000,
                TaxableAmountC = 0,
                TaxableAmountD = 0,
                TotalAmount = 250000,
                TotalItemCount = 2,
                TotalTaxAmount = 38135,
                TotalTaxableAmount = 250000
            };

            // Act
            var resultJson = jsonSerializer.Serialize(testObject);

            // Assert
            resultJson.Should().Be(expectedJson);
        }

        [Fact]
        public void ShouldDeserializeFromJson()
        {
            // Arrange
            var json = "{\"tin\":\"999999991\",\"bhfId\":\"00\",\"invcNo\":15,\"orgInvcNo\":0,\"custTin\":\"999999992\",\"custNm\":\"RRA\",\"salesTyCd\":\"N\",\"rcptTyCd\":\"S\",\"pmtTyCd\":\"01\",\"salesSttsCd\":\"02\",\"cfmDt\":\"20210709120300\",\"salesDt\":\"20210709\",\"stockRlsDt\":\"20210709120300\",\"cnclReqDt\":null,\"cnclDt\":null,\"rfdDt\":null,\"rfdRsnCd\":null,\"totItemCnt\":2,\"taxblAmtA\":0,\"taxblAmtB\":250000,\"taxblAmtC\":0,\"taxblAmtD\":0,\"taxRtA\":0,\"taxRtB\":18,\"taxRtC\":0,\"taxRtD\":0,\"taxAmtA\":0,\"taxAmtB\":94576,\"taxAmtC\":0,\"taxAmtD\":0,\"totTaxblAmt\":250000,\"totTaxAmt\":38135,\"totAmt\":250000,\"prchrAcptcYn\":\"N\",\"remark\":null,\"regrId\":\"11999\",\"regrNm\":\"Test VSDC\",\"modrId\":\"45678\",\"modrNm\":\"TestVSDC\",\"receipt\":{\"custTin\":\"100110263\",\"custMblNo\":null,\"rptNo\":1,\"trdeNm\":\"\",\"adrs\":\"\",\"topMsg\":\"Shopwithus\",\"btmMsg\":\"Welcome\",\"prchrAcptcYn\":\"N\"},\"itemList\":[{\"itemSeq\":1,\"itemCd\":\"RW1NTXU0000001\",\"itemClsCd\":\"5059690800\",\"itemNm\":\"OutDoorUnit\",\"bcd\":null,\"pkgUnitCd\":\"NT\",\"pkg\":1,\"qtyUnitCd\":\"U\",\"qty\":1,\"prc\":200000,\"splyAmt\":200000,\"dcRt\":0,\"dcAmt\":0,\"isrccCd\":null,\"isrccNm\":null,\"isrcRt\":null,\"isrcAmt\":null,\"taxTyCd\":\"B\",\"taxblAmt\":200000,\"taxAmt\":30508,\"totAmt\":200000},{\"itemSeq\":2,\"itemCd\":\"RW1NTXU0000002\",\"itemClsCd\":\"5022110801\",\"itemNm\":\"Networ kCable\",\"bcd\":null,\"pkgUnitCd\":\"NT\",\"pkg\":1,\"qtyUnitCd\":\"U\",\"qty\":1,\"prc\":50000,\"splyAmt\":50000,\"dcRt\":0,\"dcAmt\":0,\"isrccCd\":null,\"isrccNm\":null,\"isrcRt\":null,\"isrcAmt\":null,\"taxTyCd\":\"B\",\"taxblAmt\":50000,\"taxAmt\":7627,\"totAmt\":50000}]}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            SaveSalesRequest? model = jsonSerializer.Deserialize<SaveSalesRequest>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Tin.Should().Be("999999991");
            model.BranchId.Should().Be("00");
            model.ValidatedDate.Should().Be("20210709120300");
            model.CanceledDate.Should().BeNull();
            model.CancelReqeuestedDate.Should().BeNull();
            model.CustomerTin.Should().Be("999999992");
            model.InvoiceNumber.Should().Be(15);
            model.ItemList.Should().NotBeNullOrEmpty();
            model.ItemList![0].Barcode.Should().BeNull();
            model.ItemList[0].DiscountAmount.Should().Be(0);
            model.ItemList[0].DiscountRate.Should().Be(0);
            model.ItemList[0].InsuranceAmount.Should().BeNull();
            model.ItemList[0].InsuranceRate.Should().BeNull();
            model.ItemList[0].InsuranceCompanyCode.Should().BeNull();
            model.ItemList[0].InsuranceCompanyName.Should().BeNull();
            model.ItemList[0].ItemCode.Should().Be("RW1NTXU0000001");
            model.ItemList[0].ItemClassificationCode.Should().Be("5059690800");
            model.ItemList[0].ItemName.Should().Be("OutDoorUnit");
            model.ItemList[0].ItemSequenceNumber.Should().Be(1);
            model.ItemList[0].Package.Should().Be(1);
            model.ItemList[0].PackagingUnitCode.Should().Be("NT");
            model.ItemList[0].UnitPrice.Should().Be(200000);
            model.ItemList[0].TaxAmount.Should().Be(30508);
            model.ItemList[0].TaxationTypeCode.Should().Be("B");
            model.ItemList[0].TaxableAmount.Should().Be(200000);
            model.ItemList[0].TotalAmount.Should().Be(200000);
            model.ModifierId.Should().Be("45678");
            model.ModifierName.Should().Be("TestVSDC");
            model.OriginalInvoiceNumber.Should().Be(0);
            model.PaymentTypeCode.Should().Be("01");
            model.PurchaseAcceptYesNo.Should().Be("N");
            model.ReceiptTypeCode.Should().Be("S");
            model.Receipt.Should().NotBeNull();
            model.Receipt!.Address.Should().BeEmpty();
            model.Receipt.BottomMessage.Should().Be("Welcome");
            model.Receipt.CustomerMobileNumber.Should().BeNull();
            model.Receipt.CustomerTin.Should().Be("100110263");
            model.Receipt.BuyersReceiveItemYesNo.Should().Be("N");
            model.Receipt.ReportNumber.Should().Be(1);
            model.Receipt.TopMessage.Should().Be("Shopwithus");
            model.Receipt.TradeName.Should().BeEmpty();
            model.RegistrantId.Should().Be("11999");
            model.RegistrantName.Should().Be("Test VSDC");
            model.Remark.Should().BeNull();
            model.RefundedDate.Should().BeNull();
            model.RefundedReasonCode.Should().BeNull();
            model.SaleDate.Should().Be("20210709");
            model.InvoiceStatusCode.Should().Be("02");
            model.SalesTypeCode.Should().Be("N");
            model.StockReleasedDate.Should().Be("20210709120300");
            model.TaxRateD.Should().Be(0);
            model.TaxAmtA.Should().Be(0);
            model.TaxAmtB.Should().Be(94576);
            model.TaxAmtC.Should().Be(0);
            model.TaxAmtD.Should().Be(0);
            model.TaxRateA.Should().Be(0);
            model.TaxRateB.Should().Be(18);
            model.TaxRateC.Should().Be(0);
            model.TaxableAmountA.Should().Be(0);
            model.TaxableAmountB.Should().Be(250000);
            model.TaxableAmountC.Should().Be(0);
            model.TaxableAmountD.Should().Be(0);
            model.TotalAmount.Should().Be(250000);
            model.TotalItemCount.Should().Be(2);
            model.TotalTaxAmount.Should().Be(38135);
            model.TotalTaxableAmount.Should().Be(250000);
        }
    }
}
