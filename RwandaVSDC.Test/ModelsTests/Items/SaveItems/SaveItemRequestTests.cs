using FluentAssertions;
using RwandaVSDC.Models.Branches.SaveBrancheInsurances;
using RwandaVSDC.Models.Items.SaveItems;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.Items.SaveItems
{
    public class SaveItemRequestTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"itemCd\":\"RW1NTXU0000006\",\"itemClsCd\":\"5059690800\",\"itemTyCd\":\"1\",\"itemNm\":\"test material item 3\",\"itemStdNm\":null,\"orgnNatCd\":\"RW\",\"pkgUnitCd\":\"NT\",\"qtyUnitCd\":\"U\",\"taxTyCd\":\"B\",\"btchNo\":null,\"bcd\":null,\"dftPrc\":3500,\"grpPrcL1\":3500,\"grpPrcL2\":3500,\"grpPrcL3\":3500,\"grpPrcL4\":3500,\"grpPrcL5\":null,\"addInfo\":null,\"sftyQty\":null,\"isrcAplcbYn\":\"N\",\"useYn\":\"Y\",\"regrNm\":\"Admin\",\"regrId\":\"Admin\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            SaveItemRequest testObject = new SaveItemRequest
            {
                Tin = "999991130",
                BranchId = "00",
                AdditionalInformation = null,
                Barcode = null,
                BatchNumber = null,
                DefaultUnitPrice = 3500,
                Group1UnitPrice = 3500,
                Group2UnitPrice = 3500,
                Group3UnitPrice = 3500,
                Group4UnitPrice = 3500,
                Group5UnitPrice = null,
                InsuranceAppicableYesNo = "N",
                ItemCode = "RW1NTXU0000006",
                ItemClassificationCode = "5059690800",
                ItemName = "test material item 3",
                ItemStandardName = null,
                ItemTypeCode = "1",
                OriginPlaceCode = "RW",
                PackagingUnitCode = "NT",
                QuantityUnitCode = "U",
                SaftyQuantity = null,
                TaxationTypeCode = "B",
                UsedYesNo = "Y",
                ModifierID = "Admin",
                ModifierName = "Admin",
                RegistrantID = "Admin",
                RegistrantName = "Admin"
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
            var json = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"itemCd\":\"RW1NTXU0000006\",\"itemClsCd\":\"5059690800\",\"itemTyCd\":\"1\",\"itemNm\":\"test material item 3\",\"itemStdNm\":null,\"orgnNatCd\":\"RW\",\"pkgUnitCd\":\"NT\",\"qtyUnitCd\":\"U\",\"taxTyCd\":\"B\",\"btchNo\":null,\"bcd\":null,\"dftPrc\":3500,\"grpPrcL1\":3500,\"grpPrcL2\":3500,\"grpPrcL3\":3500,\"grpPrcL4\":3500,\"grpPrcL5\":null,\"addInfo\":null,\"sftyQty\":null,\"isrcAplcbYn\":\"N\",\"useYn\":\"Y\",\"regrNm\":\"Admin\",\"regrId\":\"Admin\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            SaveItemRequest? model = jsonSerializer.Deserialize<SaveItemRequest>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Tin.Should().Be("999991130");
            model.BranchId.Should().Be("00");
            model.AdditionalInformation.Should().BeNull();
            model.Barcode.Should().BeNull();
            model.BatchNumber.Should().BeNull();
            model.DefaultUnitPrice.Should().Be(3500m);
            model.Group1UnitPrice.Should().Be(3500m);
            model.Group2UnitPrice.Should().Be(3500m);
            model.Group3UnitPrice.Should().Be(3500m);
            model.Group4UnitPrice.Should().Be(3500m);
            model.Group5UnitPrice.Should().BeNull();
            model.InsuranceAppicableYesNo.Should().Be("N");
            model.ItemCode.Should().Be("RW1NTXU0000006");
            model.ItemClassificationCode.Should().Be("5059690800");
            model.ItemName.Should().Be("test material item 3");
            model.ItemStandardName.Should().BeNull();
            model.ItemTypeCode.Should().Be("1");
            model.OriginPlaceCode.Should().Be("RW");
            model.PackagingUnitCode.Should().Be("NT");
            model.QuantityUnitCode.Should().Be("U");
            model.SaftyQuantity.Should().BeNull();
            model.TaxationTypeCode.Should().Be("B");

            model.ModifierID.Should().Be("Admin");
            model.ModifierName.Should().Be("Admin");
            model.RegistrantID.Should().Be("Admin");
            model.RegistrantName.Should().Be("Admin");
            model.UsedYesNo.Should().Be("Y");
        }
    }
}
