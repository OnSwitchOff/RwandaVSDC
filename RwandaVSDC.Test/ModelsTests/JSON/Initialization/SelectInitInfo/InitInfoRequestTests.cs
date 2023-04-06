using FluentAssertions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using RwandaVSDC.Services.JsonSerializer;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using RwandaVSDC.Models.JSON.Initialization.SelectInitInfo;

namespace RwandaVSDC.Test.ModelsTests.JSON.Initialization.SelectInitInfo
{
    public class InitInfoRequestTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"dvcSrlNo\":\"dvcv1130\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            InitInfoRequest testObject = new InitInfoRequest
            {
                Tin = "999991130",
                BranchId = "00",
                DvcSrlNo = "dvcv1130"
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
            var json = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"dvcSrlNo\":\"dvcv1130\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            InitInfoRequest? model = jsonSerializer.Deserialize<InitInfoRequest>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Tin.Should().Be("999991130");
            model.BranchId.Should().Be("00");
            model.DvcSrlNo.Should().Be("dvcv1130");
        }
    }
}
