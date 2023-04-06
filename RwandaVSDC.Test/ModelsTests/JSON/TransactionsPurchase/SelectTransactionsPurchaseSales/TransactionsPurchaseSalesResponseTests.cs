using FluentAssertions;
using RwandaVSDC.Models.JSON.TransactionsPurchase.SelectTransactionsPurchaseSales;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.JSON.TransactionsPurchase.SelectTransactionsPurchaseSales
{
    public class TransactionsPurchaseSalesResponseTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226195420\",\"data\":{\"saleList\":[{\"spplrTin\":\"999991111\",\"spplrNm\":\"Taxpayer1111\",\"spplrBhfId\":\"00\",\"spplrInvcNo\":2,\"spplrSdcId\":\"SDC007000001\",\"spplrMrcNo\":\"WIS01000101\",\"rcptTyCd\":\"S\",\"pmtTyCd\":\"01\",\"cfmDt\":\"2020-01-27 21:03:00\",\"salesDt\":\"20200127\",\"stockRlsDt\":\"2020-01-27 21:03:00\",\"totItemCnt\":2,\"taxblAmtA\":0,\"taxblAmtB\":10500,\"taxblAmtC\":0,\"taxblAmtD\":0,\"taxRtA\":0,\"taxRtB\":18,\"taxRtC\":0,\"taxRtD\":0,\"taxAmtA\":0,\"taxAmtB\":1890,\"taxAmtC\":0,\"taxAmtD\":0,\"totTaxblAmt\":10500,\"totTaxAmt\":1890,\"totAmt\":10500,\"remark\":null,\"itemList\":[{\"itemSeq\":1,\"itemCd\":\"RW1NTXU0000001\",\"itemClsCd\":\"5059690800\",\"itemNm\":\"test item 1\",\"bcd\":null,\"pkgUnitCd\":\"NT\",\"pkg\":2,\"qtyUnitCd\":\"U\",\"qty\":2,\"prc\":3500,\"splyAmt\":7000,\"dcRt\":0,\"dcAmt\":0,\"taxTyCd\":\"B\",\"taxblAmt\":7000,\"taxAmt\":1260,\"totAmt\":10500},{\"itemSeq\":2,\"itemCd\":\"RW1NTXU0000002\",\"itemClsCd\":\"5022110801\",\"itemNm\":\"test item 2\",\"bcd\":null,\"pkgUnitCd\":\"NT\",\"pkg\":1,\"qtyUnitCd\":\"U\",\"qty\":1,\"prc\":3500,\"splyAmt\":3500,\"dcRt\":0,\"dcAmt\":0,\"taxTyCd\":\"B\",\"taxblAmt\":3500,\"taxAmt\":630,\"totAmt\":10500}]}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            TransactionsPurchaseSalesResponse testObject = new TransactionsPurchaseSalesResponse
            {
                Data = new TransactionsPurchaseSalesData
                {
                    SaleList = new List<TransactionsPurchaseSalesInformation>
                    {
                        new TransactionsPurchaseSalesInformation
                        {
                            ValidatedDate = "2020-01-27 21:03:00",
                            ItemList = new List<TransactionsPurchaseSalesItemInformation>
                            {
                                new TransactionsPurchaseSalesItemInformation
                                {
                                    Barcode = null,
                                    DiscountAmount = 0,
                                    DiscountRate = 0,
                                    ItemCode = "RW1NTXU0000001",
                                    ItemClassificationCode = "5059690800",
                                    ItemName = "test item 1",
                                    ItemSequenceNumber = 1,
                                    Package = 2,
                                    PackagingUnitCode = "NT",
                                    UnitPrice = 3500,
                                    Quantity = 2,
                                    QuantityUnitCode = "U",
                                    SupplyAmount = 7000,
                                    TaxAmount = 1260,
                                    TaxationTypeCode = "B",
                                    TaxableAmount = 7000,
                                    TotalAmount = 10500
                                },
                                new TransactionsPurchaseSalesItemInformation
                                {
                                    Barcode = null,
                                    DiscountAmount = 0,
                                    DiscountRate = 0,
                                    ItemCode = "RW1NTXU0000002",
                                    ItemClassificationCode = "5022110801",
                                    ItemName = "test item 2",
                                    ItemSequenceNumber = 2,
                                    Package = 1,
                                    PackagingUnitCode = "NT",
                                    UnitPrice = 3500,
                                    Quantity = 1,
                                    QuantityUnitCode = "U",
                                    SupplyAmount = 3500,
                                    TaxAmount = 630,
                                    TaxationTypeCode = "B",
                                    TaxableAmount = 3500,
                                    TotalAmount = 10500
                                }
                            },
                            PaymentTypeCode = "01",
                            ReceiptTypeCode = "S",
                            Remark = null,
                            SaleDate = "20200127",
                            SupplierBranchId = "00",
                            SupplierInvoiceNumber = 2,
                            SpplrMrcNo = "WIS01000101",
                            SupplierName = "Taxpayer1111",
                            SpplrSdcId = "SDC007000001",
                            SupplierTin = "999991111",
                            StockReleasedDate ="2020-01-27 21:03:00",
                            TaxAmtA = 0,
                            TaxAmtB = 1890,
                            TaxAmtC = 0,
                            TaxAmtD = 0,
                            TaxRateA = 0,
                            TaxRateB = 18,
                            TaxRateC = 0,
                            TaxRateD = 0,
                            TaxableAmountA = 0,
                            TaxableAmountB = 10500,
                            TaxableAmountC = 0,
                            TaxableAmountD = 0,
                            TotalAmount = 10500,
                            TotalItemCount = 2,
                            TotalTaxAmount = 1890,
                            TotalTaxableAmount = 10500
                        }
                    }
                },
                ResultCode = "000",
                ResultDate = "20200226195420",
                ResultMessage = "It is succeeded"
            };

            // Act
            var resultJson = jsonSerializer.Serialize(testObject);

            // Assert
            resultJson.Should().Be(expectedJson);
        }

        [Fact]
        public void ShouldDeserializeFromJson()
        {
            //Arrange
            var json = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226195420\",\"data\":{\"saleList\":[{\"spplrTin\":\"999991111\",\"spplrNm\":\"Taxpayer1111\",\"spplrBhfId\":\"00\",\"spplrInvcNo\":99999999999999999999999999999999999999,\"spplrSdcId\":\"SDC007000001\",\"spplrMrcNo\":\"WIS01000101\",\"rcptTyCd\":\"S\",\"pmtTyCd\":\"01\",\"cfmDt\":\"2020-01-27 21:03:00\",\"salesDt\":\"20200127\",\"stockRlsDt\":\"2020-01-27 21:03:00\",\"totItemCnt\":2,\"taxblAmtA\":0,\"taxblAmtB\":10500,\"taxblAmtC\":0,\"taxblAmtD\":0,\"taxRtA\":0,\"taxRtB\":18,\"taxRtC\":0,\"taxRtD\":0,\"taxAmtA\":0,\"taxAmtB\":1890,\"taxAmtC\":0,\"taxAmtD\":0,\"totTaxblAmt\":10500,\"totTaxAmt\":1890,\"totAmt\":10500,\"remark\":null,\"itemList\":[{\"itemSeq\":1,\"itemCd\":\"RW1NTXU0000001\",\"itemClsCd\":\"5059690800\",\"itemNm\":\"test item 1\",\"bcd\":null,\"pkgUnitCd\":\"NT\",\"pkg\":2,\"qtyUnitCd\":\"U\",\"qty\":2,\"prc\":3500,\"splyAmt\":7000,\"dcRt\":0,\"dcAmt\":0,\"taxTyCd\":\"B\",\"taxblAmt\":7000,\"taxAmt\":1260,\"totAmt\":10500},{\"itemSeq\":2,\"itemCd\":\"RW1NTXU0000002\",\"itemClsCd\":\"5022110801\",\"itemNm\":\"test item 2\",\"bcd\":null,\"pkgUnitCd\":\"NT\",\"pkg\":1,\"qtyUnitCd\":\"U\",\"qty\":1,\"prc\":3500,\"splyAmt\":3500,\"dcRt\":0,\"dcAmt\":0,\"taxTyCd\":\"B\",\"taxblAmt\":3500,\"taxAmt\":630,\"totAmt\":10500}]}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            TransactionsPurchaseSalesResponse? model = jsonSerializer.Deserialize<TransactionsPurchaseSalesResponse>(json);

            // Assert
            model.Should().NotBeNull();
            model!.ResultCode.Should().Be("000");
            model.ResultDate.Should().Be("20200226195420");
            model.ResultMessage.Should().Be("It is succeeded");

            model.Data.Should().NotBeNull();
            model.Data!.SaleList.Should().NotBeNullOrEmpty();
            model.Data.SaleList![0].ValidatedDate.Should().Be("2020-01-27 21:03:00");
            model.Data.SaleList[0].PaymentTypeCode.Should().Be("01");
            model.Data.SaleList[0].ReceiptTypeCode.Should().Be("S");
            model.Data.SaleList[0].Remark.Should().BeNull();
            model.Data.SaleList[0].SaleDate.Should().Be("20200127");
            model.Data.SaleList[0].SupplierBranchId.Should().Be("00");
            model.Data.SaleList[0].SupplierInvoiceNumber.Should().Be(BigInteger.Parse("99999999999999999999999999999999999999"));
            model.Data.SaleList[0].SpplrMrcNo.Should().Be("WIS01000101");
            model.Data.SaleList[0].SupplierName.Should().Be("Taxpayer1111");
            model.Data.SaleList[0].SpplrSdcId.Should().Be("SDC007000001");
            model.Data.SaleList[0].SupplierTin.Should().Be("999991111");
            model.Data.SaleList[0].StockReleasedDate.Should().Be("2020-01-27 21:03:00");
            model.Data.SaleList[0].TaxAmtA.Should().Be(0);
            model.Data.SaleList[0].TaxAmtB.Should().Be(1890);
            model.Data.SaleList[0].TaxAmtC.Should().Be(0);
            model.Data.SaleList[0].TaxAmtD.Should().Be(0);
            model.Data.SaleList[0].TaxRateA.Should().Be(0);
            model.Data.SaleList[0].TaxRateB.Should().Be(18);
            model.Data.SaleList[0].TaxRateC.Should().Be(0);
            model.Data.SaleList[0].TaxRateD.Should().Be(0);
            model.Data.SaleList[0].TaxableAmountA.Should().Be(0);
            model.Data.SaleList[0].TaxableAmountB.Should().Be(10500);
            model.Data.SaleList[0].TaxableAmountC.Should().Be(0);
            model.Data.SaleList[0].TaxableAmountD.Should().Be(0);
            model.Data.SaleList[0].TotalAmount.Should().Be(10500);
            model.Data.SaleList[0].TotalItemCount.Should().Be(2);
            model.Data.SaleList[0].TotalTaxAmount.Should().Be(1890);
            model.Data.SaleList[0].TotalTaxableAmount.Should().Be(10500);
            model.Data.SaleList[0].ItemList.Should().NotBeNullOrEmpty();
            model.Data.SaleList[0].ItemList![0].Barcode.Should().BeNull();
            model.Data.SaleList[0].ItemList![0].DiscountAmount.Should().Be(0);
            model.Data.SaleList[0].ItemList![0].DiscountRate.Should().Be(0);
            model.Data.SaleList[0].ItemList![0].ItemCode.Should().Be("RW1NTXU0000001");
            model.Data.SaleList[0].ItemList![0].ItemClassificationCode.Should().Be("5059690800");
            model.Data.SaleList[0].ItemList![0].ItemName.Should().Be("test item 1");
            model.Data.SaleList[0].ItemList![0].ItemSequenceNumber.Should().Be(1);
            model.Data.SaleList[0].ItemList![0].Package.Should().Be(2);
            model.Data.SaleList[0].ItemList![0].PackagingUnitCode.Should().Be("NT");
            model.Data.SaleList[0].ItemList![0].UnitPrice.Should().Be(3500);
            model.Data.SaleList[0].ItemList![0].Quantity.Should().Be(2);
            model.Data.SaleList[0].ItemList![0].QuantityUnitCode.Should().Be("U");
            model.Data.SaleList[0].ItemList![0].SupplyAmount.Should().Be(7000);
            model.Data.SaleList[0].ItemList![0].TaxAmount.Should().Be(1260);
            model.Data.SaleList[0].ItemList![0].TaxationTypeCode.Should().Be("B");
            model.Data.SaleList[0].ItemList![0].TaxableAmount.Should().Be(7000);
            model.Data.SaleList[0].ItemList![0].TotalAmount.Should().Be(10500);
        }
    }
}
