using FluentAssertions;
using RwandaVSDC.Models.JSON.Branches.SaveBrancheCustomers;
using RwandaVSDC.Models.JSON.Branches.SaveBrancheInsurances;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.JSON.Branches.SaveBrancheInsurances
{
    public class SaveBranchInsuranceRequestTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"tin\":\"999000099\",\"bhfId\":\"00\",\"isrccCd\":\"ISRCC01\",\"isrccNm\":\"RSSB Insurance\",\"isrcRt\":20,\"useYn\":\"Y\",\"regrNm\":\"Admin\",\"regrId\":\"Admin\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            SaveBranchInsuranceRequest testObject = new SaveBranchInsuranceRequest
            {
                BranchId = "00",
                PremiumRate = 20,
                InsuranceCode = "ISRCC01",
                InsuranceName = "RSSB Insurance",
                ModifierID = "Admin",
                ModifierName = "Admin",
                RegistrantID = "Admin",
                RegistrantName = "Admin",
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
            var json = "{\"tin\":\"999000099\",\"bhfId\":\"00\",\"isrccCd\":\"ISRCC01\",\"isrccNm\":\"RSSB Insurance\",\"isrcRt\":20,\"useYn\":\"Y\",\"regrNm\":\"Admin\",\"regrId\":\"Admin\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            SaveBranchInsuranceRequest? model = jsonSerializer.Deserialize<SaveBranchInsuranceRequest>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Tin.Should().Be("999000099");
            model.BranchId.Should().Be("00");
            model.PremiumRate.Should().Be(20);
            model.InsuranceCode.Should().Be("ISRCC01");
            model.InsuranceName.Should().Be("RSSB Insurance");
            model.ModifierID.Should().Be("Admin");
            model.ModifierName.Should().Be("Admin");
            model.RegistrantID.Should().Be("Admin");
            model.RegistrantName.Should().Be("Admin");
            model.UsedYesNo.Should().Be("Y");
        }
    }
}
