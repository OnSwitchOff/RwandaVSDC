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
    public class SaveBranchCustomerRequestTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"tin\":\"999000099\",\"bhfId\":\"00\",\"custNo\":\"999991113\",\"custTin\":\"107397100\",\"custNm\":\"ERIRWANDA\",\"adrs\":null,\"telNo\":null,\"email\":null,\"faxNo\":null,\"useYn\":\"Y\",\"remark\":null,\"regrNm\":\"Admin\",\"regrId\":\"Admin\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            SaveBranchCustomerRequest testObject = new SaveBranchCustomerRequest
            {
                Address = null,
                BranchId = "00",
                CustomerName = "ERIRWANDA",
                CustomerNumber = "999991113",
                CustomerTIN = "107397100",
                Email = null,
                FaxNumber = null,
                ModifierID = "Admin",
                ModifierName = "Admin",
                RegistrantID = "Admin",
                RegistrantName = "Admin",
                Remark = null,
                Contact = null,
                Tin = "999000099",
                UsedYesNo = "Y"
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
            var json = "{\"tin\":\"999000099\",\"bhfId\":\"00\",\"custNo\":\"999991113\",\"custTin\":\"107397100\",\"custNm\":\"ERIRWANDA\",\"adrs\":null,\"telNo\":null,\"email\":null,\"faxNo\":null,\"useYn\":\"Y\",\"remark\":null,\"regrNm\":\"Admin\",\"regrId\":\"Admin\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            SaveBranchCustomerRequest? model = jsonSerializer.Deserialize<SaveBranchCustomerRequest>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Tin.Should().Be("999000099");
            model.BranchId.Should().Be("00");
            model.CustomerName.Should().Be("ERIRWANDA");
            model.CustomerNumber.Should().Be("999991113");
            model.CustomerTIN.Should().Be("107397100");
            model.Email.Should().BeNull();
            model.FaxNumber.Should().BeNull();
            model.ModifierID.Should().Be("Admin");
            model.ModifierName.Should().Be("Admin");
            model.RegistrantID.Should().Be("Admin");
            model.RegistrantName.Should().Be("Admin");
            model.Remark.Should().BeNull();
            model.Contact.Should().BeNull();
            model.UsedYesNo.Should().Be("Y");
        }
    }
}
