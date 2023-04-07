using FluentAssertions;
using RwandaVSDC.Models.JSON.Stock.SaveStockItems;
using RwandaVSDC.Models.JSON.Stock.SelectStockItems;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.JSON.Stock.SaveStockItems
{
    public class SaveStockRequestTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"sarNo\":2,\"orgSarNo\":2,\"regTyCd\":\"M\",\"custTin\":null,\"custNm\":null,\"custBhfId\":null,\"sarTyCd\":\"11\",\"ocrnDt\":\"20200126\",\"totItemCnt\":2,\"totTaxblAmt\":70000,\"totTaxAmt\":12000,\"totAmt\":70000,\"remark\":null,\"regrId\":\"Admin\",\"regrNm\":\"Admin\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\",\"itemList\":[{\"itemSeq\":1,\"itemCd\":\"RW1NTXU0000001\",\"itemClsCd\":\"5059690800\",\"itemNm\":\"test item 1\",\"bcd\":null,\"pkgUnitCd\":\"NI\",\"pkg\":10,\"qtyUnitCd\":\"U\",\"qty\":10,\"itemExprDt\":null,\"prc\":3500,\"splyAmt\":35000,\"totDcAmt\":0,\"taxblAmt\":35000,\"taxTyCd\":\"B\",\"taxAmt\":6000,\"totAmt\":35000},{\"itemSeq\":2,\"itemCd\":\"RW1NTXU0000002\",\"itemClsCd\":\"5059690800\",\"itemNm\":\"test item 2\",\"bcd\":null,\"pkgUnitCd\":\"NI\",\"pkg\":10,\"qtyUnitCd\":\"U\",\"qty\":10,\"itemExprDt\":null,\"prc\":3500,\"splyAmt\":35000,\"totDcAmt\":0,\"taxblAmt\":35000,\"taxTyCd\":\"B\",\"taxAmt\":6000,\"totAmt\":35000}]}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            SaveStockRequest testObject = new SaveStockRequest
            {
                Tin = "999991130",
                BranchId = "00",
                CustomerBranchOfficeId = null,
                CustomerName = null,
                CustomerTin = null,
                ModifierId = "Admin",
                ModifierName = "Admin",
                RegistrantId = "Admin",
                RegistrantName = "Admin",
                OccurredDate = "20200126",
                OriginalStoredAndReleasedNumber = 2,
                RegistrationTypeCode = "M",
                Remark = null,
                StoredAndReleasedNumber = 2,
                StoredAndReleasedTypeCode = "11",
                TotalAmount = 70000,
                TotalItemCount = 2,
                TotalTaxAmount = 12000,
                TotalTaxableAmount = 70000,
                ItemList = new List<SaveStockItemInformation>
                {
                    new SaveStockItemInformation
                    {
                        Barcode = null,
                        ItemCode = "RW1NTXU0000001",
                        ItemClassificationCode = "5059690800",
                        ItemExpiredDate = null,
                        ItemName = "test item 1",
                        ItemSequence = 1,
                        PackageQuantity = 10,
                        PackagingUnitCode = "NI",
                        UnitPrice = 3500,
                        UnitQuantity = 10,
                        QuantityUnitCode = "U",
                        SupplyAmount = 35000,
                        TaxAmount = 6000,
                        TaxationTypeCode = "B",
                        TaxableAmount = 35000,
                        TotalAmount = 35000,
                        DiscountAmount = 0
                    },
                     new SaveStockItemInformation
                    {
                        Barcode = null,
                        ItemCode = "RW1NTXU0000002",
                        ItemClassificationCode = "5059690800",
                        ItemExpiredDate = null,
                        ItemName = "test item 2",
                        ItemSequence = 2,
                        PackageQuantity = 10,
                        PackagingUnitCode = "NI",
                        UnitPrice = 3500,
                        UnitQuantity = 10,
                        QuantityUnitCode = "U",
                        SupplyAmount = 35000,
                        TaxAmount = 6000,
                        TaxationTypeCode = "B",
                        TaxableAmount = 35000,
                        TotalAmount = 35000,
                        DiscountAmount = 0
                    },
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
            var json = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"sarNo\":2,\"orgSarNo\":2,\"regTyCd\":\"M\",\"custTin\":null,\"custNm\":null,\"custBhfId\":null,\"sarTyCd\":\"11\",\"ocrnDt\":\"20200126\",\"totItemCnt\":2,\"totTaxblAmt\":70000,\"totTaxAmt\":12000,\"totAmt\":70000,\"remark\":null,\"regrId\":\"Admin\",\"regrNm\":\"Admin\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\",\"itemList\":[{\"itemSeq\":1,\"itemCd\":\"RW1NTXU0000001\",\"itemClsCd\":\"5059690800\",\"itemNm\":\"test item 1\",\"bcd\":null,\"pkgUnitCd\":\"NI\",\"pkg\":10,\"qtyUnitCd\":\"U\",\"qty\":10,\"itemExprDt\":null,\"prc\":3500,\"splyAmt\":35000,\"totDcAmt\":0,\"taxblAmt\":35000,\"taxTyCd\":\"B\",\"taxAmt\":6000,\"totAmt\":35000},{\"itemSeq\":2,\"itemCd\":\"RW1NTXU0000002\",\"itemClsCd\":\"5059690800\",\"itemNm\":\"test item 2\",\"bcd\":null,\"pkgUnitCd\":\"NI\",\"pkg\":10,\"qtyUnitCd\":\"U\",\"qty\":10,\"itemExprDt\":null,\"prc\":3500,\"splyAmt\":35000,\"totDcAmt\":0,\"taxblAmt\":35000,\"taxTyCd\":\"B\",\"taxAmt\":6000,\"totAmt\":35000}]}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            SaveStockRequest? model = jsonSerializer.Deserialize<SaveStockRequest>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Tin.Should().Be("999991130");
            model.BranchId.Should().Be("00");
            model.CustomerBranchOfficeId.Should().BeNull();
            model.CustomerName.Should().BeNull();
            model.CustomerTin.Should().BeNull();
            model.ModifierId.Should().Be("Admin");
            model.ModifierName.Should().Be("Admin");
            model.RegistrantId.Should().Be("Admin");
            model.RegistrantName.Should().Be("Admin");
            model.OccurredDate.Should().Be("20200126");
            model.OriginalStoredAndReleasedNumber.Should().Be((BigInteger)2);
            model.RegistrationTypeCode.Should().Be("M");
            model.Remark.Should().BeNull();
            model.StoredAndReleasedNumber.Should().Be((BigInteger)2);
            model.StoredAndReleasedTypeCode.Should().Be("11");
            model.TotalAmount.Should().Be(70000);
            model.TotalItemCount.Should().Be(2);
            model.TotalTaxAmount.Should().Be(12000);
            model.TotalTaxableAmount.Should().Be(70000);
            model.ItemList.Should().NotBeNullOrEmpty();
            model.ItemList![0].Barcode.Should().BeNull();
            model.ItemList[0].ItemCode.Should().Be("RW1NTXU0000001");
            model.ItemList[0].ItemClassificationCode.Should().Be("5059690800");
            model.ItemList![0].ItemExpiredDate.Should().BeNull();
            model.ItemList[0].ItemName.Should().Be("test item 1");
            model.ItemList[0].ItemSequence.Should().Be(1);
            model.ItemList[0].PackageQuantity.Should().Be(10);
            model.ItemList[0].PackagingUnitCode.Should().Be("NI");
            model.ItemList[0].UnitPrice.Should().Be(3500);
            model.ItemList[0].UnitQuantity.Should().Be(10);
            model.ItemList[0].QuantityUnitCode.Should().Be("U");
            model.ItemList[0].SupplyAmount.Should().Be(35000);
            model.ItemList[0].TaxAmount.Should().Be(6000);
            model.ItemList[0].TaxationTypeCode.Should().Be("B");
            model.ItemList[0].TaxableAmount.Should().Be(35000);
            model.ItemList[0].TotalAmount.Should().Be(35000);
            model.ItemList[0].DiscountAmount.Should().Be(0);
        }
    }
}
