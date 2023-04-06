using FluentAssertions;
using RwandaVSDC.Models.JSON.Branches.SelectBranches;
using RwandaVSDC.Models.JSON.Notices.SelectNotices;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.JSON.Notices.SelectNotices
{
    public class NoticeResponseTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226191722\",\"data\":{\"noticeList\":[{\"noticeNo\":42,\"title\":\"Notice Test [2020.02.18]\",\"cont\":\"Notice Test [2020.02.18] Notice Test [2020.02.18]\",\"dtlUrl\":\"http://localhost:9980/common/link/ebm/receipt/indexEbmNotice?noticeNo=42\",\"regrNm\":\"Administrator\",\"regDt\":\"20200218191141\"}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            NoticeResponse testObject = new NoticeResponse
            {
                Data = new NoticeResponseData
                {
                    NoticeList = new List<NoticeInformation>
                    {
                        new NoticeInformation
                        {
                            Content = "Notice Test [2020.02.18] Notice Test [2020.02.18]",
                            DetailURL = "http://localhost:9980/common/link/ebm/receipt/indexEbmNotice?noticeNo=42",
                            NoticeNumber = 42,
                            RegistrationDateTime = "20200218191141",
                            RegistrationName = "Administrator",
                            Title = "Notice Test [2020.02.18]"
                        }
                    }
                },
                ResultCode = "000",
                ResultDate = "20200226191722",
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
            var json = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226191722\",\"data\":{\"noticeList\":[{\"noticeNo\":42,\"title\":\"Notice Test [2020.02.18]\",\"cont\":\"Notice Test [2020.02.18] Notice Test [2020.02.18]\",\"dtlUrl\":\"http://localhost:9980/common/link/ebm/receipt/indexEbmNotice?noticeNo=42\",\"regrNm\":\"Administrator\",\"regDt\":\"20200218191141\"}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            NoticeResponse? response = jsonSerializer.Deserialize<NoticeResponse>(json);

            // Assert
            response.Should().NotBeNull();
            response!.Data.Should().NotBeNull();
            response.Data!.NoticeList.Should().NotBeNullOrEmpty();
            response.Data.NoticeList!.Count.Should().Be(1);


            response.Data.NoticeList[0].Content.Should().Be("Notice Test [2020.02.18] Notice Test [2020.02.18]");
            response.Data.NoticeList[0].DetailURL.Should().Be("http://localhost:9980/common/link/ebm/receipt/indexEbmNotice?noticeNo=42");
            response.Data.NoticeList[0].NoticeNumber.Should().Be(42);
            response.Data.NoticeList[0].RegistrationDateTime.Should().Be("20200218191141");
            response.Data.NoticeList[0].RegistrationName.Should().Be("Administrator");
            response.Data.NoticeList[0].Title.Should().Be("Notice Test [2020.02.18]");


            response.ResultCode.Should().Be("000");
            response.ResultDate.Should().Be("20200226191722");
            response.ResultMessage.Should().Be("It is succeeded");
        }
    }
}
