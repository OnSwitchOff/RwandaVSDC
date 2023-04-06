using FluentAssertions;
using RwandaVSDC.Models.JSON.Branches.SelectBranches;
using RwandaVSDC.Models.JSON.Branches.SaveBrancheCustomers;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.JSON.Branches.SaveBrancheCustomers
{
    public class SaveBranchCustomerResponseTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226193115\",\"data\":null}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            SaveBranchCustomerResponse testObject = new SaveBranchCustomerResponse
            {
                ResultCode = "000",
                ResultDate = "20200226193115",
                ResultMessage = "It is succeeded",
                Data = null
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
            var json = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226193115\",\"data\":null}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            SaveBranchCustomerResponse? model = jsonSerializer.Deserialize<SaveBranchCustomerResponse>(json);

            // Assert
            model.Should().NotBeNull();
            model!.ResultCode.Should().Be("000");
            model.ResultDate.Should().Be("20200226193115");
            model.ResultMessage.Should().Be("It is succeeded");
            model.Data.Should().BeNull();
        }
    }
}
