using FluentAssertions;
using RwandaVSDC.Models.Branches.SaveBrancheCustomers;
using RwandaVSDC.Models.Branches.SaveBrancheUsers;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.Branches.SaveBrancheUsers
{
    public class SaveBranchUserRequestTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"tin\":\"999000099\",\"bhfId\":\"00\",\"userId\":\"userId3\",\"userNm\":\"UserName3\",\"pwd\":\"12341234\",\"adrs\":null,\"cntc\":null,\"authCd\":null,\"remark\":null,\"useYn\":\"Y\",\"regrNm\":\"Admin\",\"regrId\":\"Admin\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            SaveBranchUserRequest testObject = new SaveBranchUserRequest
            {
                Address = null,
                AuthorityCode = null,
                BranchId = "00",
                Contact = null,
                ModifierID = "Admin",
                ModifierName = "Admin",
                RegistrantID = "Admin",
                RegistrantName = "Admin",
                Remark = null,
                Password = "12341234",
                Tin = "999000099",
                UsedYesNo = "Y",
                UserID = "userId3",
                UserName = "UserName3"
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
            var json = "{\"tin\":\"999000099\",\"bhfId\":\"00\",\"userId\":\"userId3\",\"userNm\":\"UserName3\",\"pwd\":\"12341234\",\"adrs\":null,\"cntc\":null,\"authCd\":null,\"remark\":null,\"useYn\":\"Y\",\"regrNm\":\"Admin\",\"regrId\":\"Admin\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            SaveBranchUserRequest? model = jsonSerializer.Deserialize<SaveBranchUserRequest>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Tin.Should().Be("999000099");
            model.AuthorityCode.Should().BeNull();
            model.BranchId.Should().Be("00");
            model.Contact.Should().BeNull();
            model.ModifierID.Should().Be("Admin");
            model.ModifierName.Should().Be("Admin");
            model.RegistrantID.Should().Be("Admin");
            model.RegistrantName.Should().Be("Admin");
            model.Remark.Should().BeNull();
            model.Password.Should().Be("12341234");
            model.UsedYesNo.Should().Be("Y");
            model.UserID.Should().Be("userId3");
            model.UserName.Should().Be("UserName3");
        }
    }
}
