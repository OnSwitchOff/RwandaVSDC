using FluentAssertions;
using RwandaVSDC.Models.Initialization.SelectInitInfo;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.Initialization.SelectInitInfo
{
    public class InitInfoResponseTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20220130101912\",\"data\":{\"info\":{\"tin\":\"999000099\",\"taxprNm\":\"TEST VSDC\",\"bsnsActv\":\"TESTING \",\"bhfId\":\"00\",\"bhfNm\":\"Headquarter\",\"bhfOpenDt\":\"20210214\",\"prvncNm\":\"KIGALI CITY\",\"dstrtNm\":\"GASABO\",\"sctrNm\":\"JALI\",\"locDesc\":\"KN 5 St.\",\"hqYn\":\"Y\",\"mgrNm\":\"Minsoo\",\"mgrTelNo\":\"0780000000\",\"mgrEmail\":\"test@gaoin.kr\",\"sdcId\":null,\"mrcNo\":null,\"dvcId\":\"9990000997006310\",\"intrlKey\":null,\"signKey\":null,\"cmcKey\":null,\"lastPchsInvcNo\":0,\"lastSaleRcptNo\":0,\"lastInvcNo\":null,\"lastSaleInvcNo\":0,\"lastTrainInvcNo\":null,\"lastProfrmInvcNo\":null,\"lastCopyInvcNo\":null}}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            InitInfoResponse testObject = new InitInfoResponse
            {
                Data = new InitInfoResponseData
                {
                    Info = new InitInfoResponseInfo
                    {
                        TaxpayerName = "TEST VSDC",
                        Tin = "999000099",
                        BusinessActivity = "TESTING ",
                        BranchOfficeId = "00",
                        BranchOfficeName = "Headquarter",
                        BranchDateCreated = "20210214",
                        ProvinceName = "KIGALI CITY",
                        DistrictName = "GASABO",
                        SectorName = "JALI",
                        LocationDescription = "KN 5 St.",
                        HeadQuarter = "Y",
                        ManagerName = "Minsoo",
                        ManagerContactNumber = "0780000000",
                        ManagerEmail = "test@gaoin.kr",
                        DeviceId = "9990000997006310",
                        SdcId = null,
                        MrcNo = null,
                        InternalKey = null,
                        SignKey = null,
                        CommunicationKey = null,
                        LastSaleInvoiceNumber = 0,
                        LastPurchaseInvoiceNumber = 0,
                        LastSaleReceiptNumber = 0
                    }
                },
                ResultCode = "000",
                ResultDate = "20220130101912",
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
            var json = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20220130101912\",\"data\":{\"info\":{\"tin\":\"999000099\",\"taxprNm\":\"TEST VSDC\",\"bsnsActv\":\"TESTING \",\"bhfId\":\"00\",\"bhfNm\":\"Headquarter\",\"bhfOpenDt\":\"20210214\",\"prvncNm\":\"KIGALI CITY\",\"dstrtNm\":\"GASABO\",\"sctrNm\":\"JALI\",\"locDesc\":\"KN 5 St.\",\"hqYn\":\"Y\",\"mgrNm\":\"Minsoo\",\"mgrTelNo\":\"0780000000\",\"mgrEmail\":\"test@gaoin.kr\",\"sdcId\":null,\"mrcNo\":null,\"dvcId\":\"9990000997006310\",\"intrlKey\":null,\"signKey\":null,\"cmcKey\":null,\"lastPchsInvcNo\":0,\"lastSaleRcptNo\":0,\"lastInvcNo\":null,\"lastSaleInvcNo\":0,\"lastTrainInvcNo\":null,\"lastProfrmInvcNo\":null,\"lastCopyInvcNo\":null}}}";

            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            InitInfoResponse? response = jsonSerializer.Deserialize<InitInfoResponse>(json);

            // Assert
            response.Should().NotBeNull();
            response!.Data.Should().NotBeNull();
            response.Data!.Info.Should().NotBeNull();
            response.Data.Info!.TaxpayerName.Should().Be("TEST VSDC");
            response.Data.Info.Tin.Should().Be("999000099");
            response.Data.Info.BusinessActivity.Should().Be("TESTING ");
            response.Data.Info.BranchOfficeId.Should().Be("00");
            response.Data.Info.BranchOfficeName.Should().Be("Headquarter");
            response.Data.Info.BranchDateCreated.Should().Be("20210214");
            response.Data.Info.ProvinceName.Should().Be("KIGALI CITY");
            response.Data.Info.DistrictName.Should().Be("GASABO");
            response.Data.Info.SectorName.Should().Be("JALI");
            response.Data.Info.LocationDescription.Should().Be("KN 5 St.");
            response.Data.Info.HeadQuarter.Should().Be("Y");
            response.Data.Info.ManagerName.Should().Be("Minsoo");
            response.Data.Info.ManagerContactNumber.Should().Be("0780000000");
            response.Data.Info.ManagerEmail.Should().Be("test@gaoin.kr");
            response.Data.Info.DeviceId.Should().Be("9990000997006310");
            response.Data.Info.SdcId.Should().BeNull();
            response.Data.Info.MrcNo.Should().BeNull();
            response.Data.Info.InternalKey.Should().BeNull();
            response.Data.Info.SignKey.Should().BeNull();
            response.Data.Info.CommunicationKey.Should().BeNull();
            response.Data.Info.LastSaleInvoiceNumber.Should().Be(0);
            response.Data.Info.LastPurchaseInvoiceNumber.Should().Be(0);
            response.Data.Info.LastSaleReceiptNumber.Should().Be(0);
            response.ResultCode.Should().Be("000");
            response.ResultDate.Should().Be("20220130101912");
            response.ResultMessage.Should().Be("It is succeeded");
        }
    }
}
