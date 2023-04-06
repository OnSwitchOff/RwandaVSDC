using FluentAssertions;
using RwandaVSDC.Models.JSON.Stock.SelectStockItems;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.JSON.Stock.SelectStockItems
{
    public class StockMovementResponseTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226200723\",\"data\":{\"stockList\":[{\"custTin\":\"999991130\",\"custBhfId\":\"00\",\"sarNo\":6,\"ocrnDt\":\"20200120\",\"totItemCnt\":1,\"totTaxblAmt\":1800000,\"totTaxAmt\":274576.27,\"totAmt\":1800000,\"remark\":null,\"itemList\":[{\"itemSeq\":1,\"itemCd\":\"KR2BZX0000001\",\"itemClsCd\":\"1110162100\",\"itemNm\":\"Grocery_Item#1\",\"bcd\":\"8801234567051\",\"pkgUnitCd\":\"BZ\",\"pkg\":0,\"qtyUnitCd\":\"CA\",\"qty\":450,\"itemExprDt\":null,\"prc\":4000,\"splyAmt\":1800000,\"totDcAmt\":0,\"taxblAmt\":1800000,\"taxTyCd\":\"B\",\"taxAmt\":274576.27,\"totAmt\":1800000}]},{\"custTin\":\"999991130\",\"custBhfId\":\"00\",\"sarNo\":59,\"ocrnDt\":\"20200110\",\"totItemCnt\":1,\"totTaxblAmt\":660000,\"totTaxAmt\":100677.97,\"totAmt\":660000,\"remark\":null,\"itemList\":[{\"itemSeq\":1,\"itemCd\":\"KR2AMXCRX0000001\",\"itemClsCd\":\"1110151600\",\"itemNm\":\"sample_nudle#1\",\"bcd\":\"8801234567001\",\"pkgUnitCd\":\"AM\",\"pkg\":0,\"qtyUnitCd\":\"CR\",\"qty\":600,\"itemExprDt\":null,\"prc\":1100,\"splyAmt\":660000,\"totDcAmt\":0,\"taxblAmt\":660000,\"taxTyCd\":\"B\",\"taxAmt\":100677.97,\"totAmt\":660000}]}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            StockMovementResponse testObject = new StockMovementResponse
            {
                ResultCode = "000",
                ResultDate = "20200226200723",
                ResultMessage = "It is succeeded",
                Data = new StockMovementData
                {
                    StockList = new List<StockMovementInformation>
                    {
                        new StockMovementInformation
                        {
                            CustomerBranchOfficeId = "00",
                            CustomerTin = "999991130",
                            ItemList = new List<StockItemInformation>
                            {
                                new StockItemInformation
                                {
                                    Barcode = "8801234567051",
                                    ItemCode = "KR2BZX0000001",
                                    ItemClassificationCode = "1110162100",
                                    ItemExpiredDate = null,
                                    ItemName =  "Grocery_Item#1",
                                    ItemSequence = 1,
                                    PackageQuantity = 0,
                                    PackagingUnitCode = "BZ",
                                    UnitPrice = 4000,
                                    UnitQuantity = 450,
                                    QuantityUnitCode = "CA",
                                    SupplyAmount = 1800000,
                                    TaxAmount = 274576.27m,
                                    TaxationTypeCode = "B",
                                    TaxableAmount = 1800000,
                                    TotalAmount = 1800000,
                                    DiscountRate = 0
                                }
                            },
                            OccurredDate = "20200120",
                            Remark = null,
                            StoredAndReleasedNumber = 6,
                            TotalAmount = 1800000,
                            TotalItemCount = 1,
                            TotalTaxAmount = 274576.27m,
                            TotalTaxableAmount = 1800000
                        },
                        new StockMovementInformation
                        {
                            CustomerBranchOfficeId = "00",
                            CustomerTin = "999991130",
                            ItemList = new List<StockItemInformation>
                            {
                                new StockItemInformation
                                {
                                    Barcode = "8801234567001",
                                    ItemCode = "KR2AMXCRX0000001",
                                    ItemClassificationCode = "1110151600",
                                    ItemExpiredDate = null,
                                    ItemName =  "sample_nudle#1",
                                    ItemSequence = 1,
                                    PackageQuantity = 0,
                                    PackagingUnitCode = "AM",
                                    UnitPrice = 1100,
                                    UnitQuantity = 600,
                                    QuantityUnitCode = "CR",
                                    SupplyAmount = 660000,
                                    TaxAmount = 100677.97m,
                                    TaxationTypeCode = "B",
                                    TaxableAmount = 660000,
                                    TotalAmount = 660000,
                                    DiscountRate = 0
                                }
                            },
                            OccurredDate = "20200110",
                            Remark = null,
                            StoredAndReleasedNumber = 59,
                            TotalAmount = 660000,
                            TotalItemCount = 1,
                            TotalTaxAmount = 100677.97m,
                            TotalTaxableAmount = 660000
                        },
                    }
                }
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
            var json = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226200723\",\"data\":{\"stockList\":[{\"custTin\":\"999991130\",\"custBhfId\":\"00\",\"sarNo\":6,\"ocrnDt\":\"20200120\",\"totItemCnt\":1,\"totTaxblAmt\":1800000,\"totTaxAmt\":274576.27,\"totAmt\":1800000,\"remark\":null,\"itemList\":[{\"itemSeq\":1,\"itemCd\":\"KR2BZX0000001\",\"itemClsCd\":\"1110162100\",\"itemNm\":\"Grocery_Item#1\",\"bcd\":\"8801234567051\",\"pkgUnitCd\":\"BZ\",\"pkg\":0,\"qtyUnitCd\":\"CA\",\"qty\":450,\"itemExprDt\":null,\"prc\":4000,\"splyAmt\":1800000,\"totDcAmt\":0,\"taxblAmt\":1800000,\"taxTyCd\":\"B\",\"taxAmt\":274576.27,\"totAmt\":1800000}]},{\"custTin\":\"999991130\",\"custBhfId\":\"00\",\"sarNo\":59,\"ocrnDt\":\"20200110\",\"totItemCnt\":1,\"totTaxblAmt\":660000,\"totTaxAmt\":100677.97,\"totAmt\":660000,\"remark\":null,\"itemList\":[{\"itemSeq\":1,\"itemCd\":\"KR2AMXCRX0000001\",\"itemClsCd\":\"1110151600\",\"itemNm\":\"sample_nudle#1\",\"bcd\":\"8801234567001\",\"pkgUnitCd\":\"AM\",\"pkg\":0,\"qtyUnitCd\":\"CR\",\"qty\":600,\"itemExprDt\":null,\"prc\":1100,\"splyAmt\":660000,\"totDcAmt\":0,\"taxblAmt\":660000,\"taxTyCd\":\"B\",\"taxAmt\":100677.97,\"totAmt\":660000}]}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            StockMovementResponse? model = jsonSerializer.Deserialize<StockMovementResponse>(json);

            // Assert
            model.Should().NotBeNull();
            model!.ResultCode.Should().Be("000");
            model.ResultDate.Should().Be("20200226200723");
            model.ResultMessage.Should().Be("It is succeeded");
            model.Data.Should().NotBeNull();
            model.Data!.StockList.Should().NotBeNullOrEmpty();
            model.Data.StockList![0].CustomerBranchOfficeId.Should().Be("00");
            model.Data.StockList[0].CustomerTin.Should().Be("999991130");
            model.Data.StockList[0].OccurredDate.Should().Be("20200120");
            model.Data.StockList[0].Remark.Should().BeNull();
            model.Data.StockList[0].StoredAndReleasedNumber.Should().Be((BigInteger)6);
            model.Data.StockList[0].TotalAmount.Should().Be(1800000);
            model.Data.StockList[0].TotalItemCount.Should().Be(1);
            model.Data.StockList[0].TotalTaxAmount.Should().Be(274576.27m);
            model.Data.StockList[0].TotalTaxableAmount.Should().Be(1800000);
            model.Data.StockList[0].ItemList.Should().NotBeNullOrEmpty();
            model.Data.StockList[0].ItemList![0].Barcode.Should().Be("8801234567051");
            model.Data.StockList[0].ItemList![0].ItemCode.Should().Be("KR2BZX0000001");
            model.Data.StockList[0].ItemList![0].ItemClassificationCode.Should().Be("1110162100");
            model.Data.StockList[0].ItemList![0].ItemExpiredDate.Should().BeNull();
            model.Data.StockList[0].ItemList![0].ItemName.Should().Be("Grocery_Item#1");
            model.Data.StockList[0].ItemList![0].ItemSequence.Should().Be(1);
            model.Data.StockList[0].ItemList![0].PackageQuantity.Should().Be(0);
            model.Data.StockList[0].ItemList![0].PackagingUnitCode.Should().Be("BZ");
            model.Data.StockList[0].ItemList![0].UnitPrice.Should().Be(4000);
            model.Data.StockList[0].ItemList![0].UnitQuantity.Should().Be(450);
            model.Data.StockList[0].ItemList![0].QuantityUnitCode.Should().Be("CA");
            model.Data.StockList[0].ItemList![0].SupplyAmount.Should().Be(1800000);
            model.Data.StockList[0].ItemList![0].TaxAmount.Should().Be(274576.27m);
            model.Data.StockList[0].ItemList![0].TaxationTypeCode.Should().Be("B");
            model.Data.StockList[0].ItemList![0].TaxableAmount.Should().Be(1800000);
            model.Data.StockList[0].ItemList![0].TotalAmount.Should().Be(1800000);
            model.Data.StockList[0].ItemList![0].DiscountRate.Should().Be(0);
        }
    }
}
