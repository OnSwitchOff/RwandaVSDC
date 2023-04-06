using FluentAssertions;
using RwandaVSDC.Models.JSON.Imports.SelectImportItems;
using RwandaVSDC.Models.JSON.Imports.UpdateImportItems;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.JSON.Imports.UpdateImportItems
{
    public class UpdateImportItemRequestTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"taskCd\":\"2231943\",\"dclDe\":\"20191217\",\"itemSeq\":1,\"hsCd\":\"1231531231\",\"itemClsCd\":\"5022110801\",\"itemCd\":\"RW1NTXU0000001\",\"imptItemSttsCd\":\"1\",\"remark\":\"remark\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            UpdateImportItemRequest testObject = new UpdateImportItemRequest
            {
                Tin = "999991130",
                BranchId = "00",
                DeclarationDate = "20191217",
                HSCode = "1231531231",
                ImportItemStatusCode = "1",
                ItemCode = "RW1NTXU0000001",
                ItemClassificationCode = "5022110801",
                ItemSequence = 1,
                ModifierId = "Admin",
                ModifierName = "Admin",
                Remark = "remark",
                TaskCode = "2231943"
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
            var json = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"taskCd\":\"2231943\",\"dclDe\":\"20191217\",\"itemSeq\":1,\"hsCd\":\"1231531231\",\"itemClsCd\":\"5022110801\",\"itemCd\":\"RW1NTXU0000001\",\"imptItemSttsCd\":\"1\",\"remark\":\"remark\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            UpdateImportItemRequest? model = jsonSerializer.Deserialize<UpdateImportItemRequest>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Tin.Should().Be("999991130");
            model.BranchId.Should().Be("00");
            model.DeclarationDate.Should().Be("20191217");
            model.HSCode.Should().Be("1231531231");
            model.ImportItemStatusCode.Should().Be("1");
            model.ItemCode.Should().Be("RW1NTXU0000001");
            model.ItemClassificationCode.Should().Be("5022110801");
            model.ItemSequence.Should().Be(1);
            model.ModifierId.Should().Be("Admin");
            model.ModifierName.Should().Be("Admin");
            model.Remark.Should().Be("remark");
            model.TaskCode.Should().Be("2231943");
        }
    }
}