using FluentAssertions;
using RwandaVSDC.Models.JSON.Stock.SaveStockMaster;
using RwandaVSDC.Models.JSON.Stock.SelectStockItems;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.JSON.Stock.SaveStockMaster
{
    public class SaveStockMasterRequestTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"itemCd\":\"RW1NTXU0000002\",\"rsdQty\":10,\"regrId\":\"Admin\",\"regrNm\":\"Admin\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            SaveStockMasterRequest testObject = new SaveStockMasterRequest
            {
                Tin = "999991130",
                BranchId = "00",
                ItemCode = "RW1NTXU0000002",
                RemainQuantity = 10,
                RegistrantName = "Admin",
                RegistrantId = "Admin",
                ModifierId = "Admin",
                ModifierName = "Admin"
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
            var json = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"itemCd\":\"RW1NTXU0000002\",\"rsdQty\":10,\"regrId\":\"Admin\",\"regrNm\":\"Admin\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            SaveStockMasterRequest? model = jsonSerializer.Deserialize<SaveStockMasterRequest>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Tin.Should().Be("999991130");
            model.BranchId.Should().Be("00");
            model.ItemCode.Should().Be("RW1NTXU0000002");
            model.RemainQuantity.Should().Be(10);
            model.RegistrantId.Should().Be("Admin");
            model.RegistrantName.Should().Be("Admin");
            model.ModifierId.Should().Be("Admin");
            model.ModifierName.Should().Be("Admin");
        }
    }
}
