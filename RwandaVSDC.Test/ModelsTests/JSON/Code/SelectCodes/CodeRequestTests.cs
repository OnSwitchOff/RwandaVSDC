using FluentAssertions;
using RwandaVSDC.Models.JSON.Initialization.SelectInitInfo;
using RwandaVSDC.Models.JSON.Code.SelectCodes;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.JSON.Code.SelectCodes
{
    public class CodeRequestTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"lastReqDt\":\"20180520000000\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            CodeRequest testObject = new CodeRequest
            {
                Tin = "999991130",
                BranchId = "00",
                LastRequestDate = "20180520000000"
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
            var json = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"lastReqDt\":\"20180520000000\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            CodeRequest? model = jsonSerializer.Deserialize<CodeRequest>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Tin.Should().Be("999991130");
            model.BranchId.Should().Be("00");
            model.LastRequestDate.Should().Be("20180520000000");
        }
    }
}
