using FluentAssertions;
using RwandaVSDC.Models.JSON.ItemClass.SelectItemsClass;
using RwandaVSDC.Models.JSON.Customers.SelectCustomer;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.JSON.Customers.SelectCustomer
{
    public class CustomerRequestTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"custmTin\":\"100600570\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            CustomerRequest testObject = new CustomerRequest
            {
                Tin = "999991130",
                BranchId = "00",
                CustomerTin = "100600570"
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
            var json = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"custmTin\":\"100600570\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            CustomerRequest? model = jsonSerializer.Deserialize<CustomerRequest>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Tin.Should().Be("999991130");
            model.BranchId.Should().Be("00");
            model.CustomerTin.Should().Be("100600570");
        }
    }
}
