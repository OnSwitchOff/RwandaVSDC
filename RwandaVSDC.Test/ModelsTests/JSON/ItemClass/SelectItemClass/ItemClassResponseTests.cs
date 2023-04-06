using FluentAssertions;
using RwandaVSDC.Models.JSON.Initialization.SelectInitInfo;
using RwandaVSDC.Models.JSON.ItemClass.SelectItemsClass;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.JSON.ItemClass.SelectItemClass
{
    public class ItemClassResponseTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226185625\",\"data\":{\"itemClsList\":[{\"itemClsCd\":\"14111400\",\"itemClsNm\":\"Paper products no use\",\"itemClsLvl\":3,\"taxTyCd\":null,\"mjrTgYn\":null,\"useYn\":\"Y\"},{\"itemClsCd\":\"14111401\",\"itemClsNm\":\"Paper products no use Commodity\",\"itemClsLvl\":4,\"taxTyCd\":null,\"mjrTgYn\":null,\"useYn\":\"Y\"},{\"itemClsCd\":\"3133130600\",\"itemClsNm\":\"Non metallic sonic welded structural assemblies\",\"itemClsLvl\":5,\"taxTyCd\":\"B\",\"mjrTgYn\":\"N\",\"useYn\":\"Y\"}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            ItemClassResponse testObject = new ItemClassResponse
            {
                Data = new ItemClassResponseData
                {
                    ItemClassList = new List<ItemClassificationInformation>
                    {
                        new ItemClassificationInformation
                        {
                            ItemClassCode = "14111400",
                            ItemClassLevel = 3,
                            ItemClassName = "Paper products no use",
                            MajorTagetYesNo = null,
                            TaxationTypeCode = null,
                            UseYesNo = "Y"
                        },
                        new ItemClassificationInformation
                        {
                            ItemClassCode = "14111401",
                            ItemClassLevel = 4,
                            ItemClassName = "Paper products no use Commodity",
                            MajorTagetYesNo = null,
                            TaxationTypeCode = null,
                            UseYesNo = "Y"
                        },
                        new ItemClassificationInformation
                        {
                            ItemClassCode = "3133130600",
                            ItemClassLevel = 5,
                            ItemClassName = "Non metallic sonic welded structural assemblies",
                            MajorTagetYesNo = "N",
                            TaxationTypeCode = "B",
                            UseYesNo = "Y"
                        },
                    }
                },
                ResultCode = "000",
                ResultDate = "20200226185625",
                ResultMessage = "It is succeeded"
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
            var json = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226185625\",\"data\":{\"itemClsList\":[{\"itemClsCd\":\"14111400\",\"itemClsNm\":\"Paper products no use\",\"itemClsLvl\":3,\"taxTyCd\":null,\"mjrTgYn\":null,\"useYn\":\"Y\"},{\"itemClsCd\":\"14111401\",\"itemClsNm\":\"Paper products no use Commodity\",\"itemClsLvl\":4,\"taxTyCd\":null,\"mjrTgYn\":null,\"useYn\":\"Y\"},{\"itemClsCd\":\"3133130600\",\"itemClsNm\":\"Non metallic sonic welded structural assemblies\",\"itemClsLvl\":5,\"taxTyCd\":\"B\",\"mjrTgYn\":\"N\",\"useYn\":\"Y\"}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            ItemClassResponse? response = jsonSerializer.Deserialize<ItemClassResponse>(json);

            // Assert
            response.Should().NotBeNull();
            response!.Data.Should().NotBeNull();
            response.Data!.ItemClassList.Should().NotBeNullOrEmpty();
            response.Data.ItemClassList!.Count.Should().Be(3);

            response.Data.ItemClassList[0].ItemClassCode.Should().Be("14111400");
            response.Data.ItemClassList[0].ItemClassLevel.Should().Be(3);
            response.Data.ItemClassList[0].ItemClassName.Should().Be("Paper products no use");
            response.Data.ItemClassList[0].MajorTagetYesNo.Should().BeNull();
            response.Data.ItemClassList[0].TaxationTypeCode.Should().BeNull();
            response.Data.ItemClassList[0].UseYesNo.Should().Be("Y");

            response.ResultCode.Should().Be("000");
            response.ResultDate.Should().Be("20200226185625");
            response.ResultMessage.Should().Be("It is succeeded");
        }
    }
}
