using FluentAssertions;
using RwandaVSDC.Models.JSON.Items.SaveItems;
using RwandaVSDC.Models.JSON.TransactionsSales.SaveSales;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.JSON.TransactionsSales.SaveSales
{
    public class SaveSalesResponseTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226194328\",\"data\":{\"rcptNo\":27,\"intrlData\":\"GZGGIZLYTJSSD7YLYLGIIG6FCY\",\"rcptSign\":\"TQZMKL57AGBMSTPO\",\"totRcptNo\":32,\"vsdcRcptPbctDate\":\"20211027162114\",\"sdcId\":\"SDC010000005\",\"mrcNo\":\"WIS01006230\"}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            SaveSalesResponse testObject = new SaveSalesResponse
            {
                ResultCode = "000",
                ResultDate = "20200226194328",
                ResultMessage = "It is succeeded",
                Data = new SaveSalesResponseData
                {
                    intrlData = "GZGGIZLYTJSSD7YLYLGIIG6FCY",
                    mrcNo = "WIS01006230",
                    rcptNo = 27,
                    rcptSign = "TQZMKL57AGBMSTPO",
                    sdcId = "SDC010000005",
                    totRcptNo = 32,
                    vsdcRcptPbctDate = "20211027162114"
                }
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
            var json = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226194328\",\"data\":{\"rcptNo\":27,\"intrlData\":\"GZGGIZLYTJSSD7YLYLGIIG6FCY\",\"rcptSign\":\"TQZMKL57AGBMSTPO\",\"totRcptNo\":32,\"vsdcRcptPbctDate\":\"20211027162114\",\"sdcId\":\"SDC010000005\",\"mrcNo\":\"WIS01006230\"}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            SaveSalesResponse? model = jsonSerializer.Deserialize<SaveSalesResponse>(json);

            // Assert
            model.Should().NotBeNull();
            model!.ResultCode.Should().Be("000");
            model.ResultDate.Should().Be("20200226194328");
            model.ResultMessage.Should().Be("It is succeeded");
            model.Data.Should().NotBeNull();
            model.Data!.intrlData.Should().Be("GZGGIZLYTJSSD7YLYLGIIG6FCY");
            model.Data.mrcNo.Should().Be("WIS01006230");
            model.Data.rcptNo.Should().Be(27);
            model.Data.rcptSign.Should().Be("TQZMKL57AGBMSTPO");
            model.Data.sdcId.Should().Be("SDC010000005");
            model.Data.totRcptNo.Should().Be(32);
            model.Data.vsdcRcptPbctDate.Should().Be("20211027162114");
        }
    }
}
