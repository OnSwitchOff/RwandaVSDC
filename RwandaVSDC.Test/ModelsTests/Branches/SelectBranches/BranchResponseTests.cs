using FluentAssertions;
using RwandaVSDC.Models.Branches.SelectBranches;
using RwandaVSDC.Models.Customers.SelectCustomer;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.Branches.SelectBranches
{
    public class BranchResponseTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226193023\",\"data\":{\"bhfList\":[{\"tin\":\"999991130\",\"bhfId\":\"00\",\"bhfNm\":\"Headquater\",\"bhfSttsCd\":\"01\",\"prvncNm\":\"KIGALI CITY\",\"dstrtNm\":\"GASABO\",\"sctrNm\":\"KACYIRU\",\"locDesc\":null,\"mgrNm\":\"manage1130_00\",\"mgrTelNo\":\"0789001130\",\"mgrEmail\":\"manage113000@test.com\",\"hqYn\":\"Y\"},{\"tin\":\"999991130\",\"bhfId\":\"01\",\"bhfNm\":\"Branch01\",\"bhfSttsCd\":\"01\",\"prvncNm\":\"KIGALICITY\",\"dstrtNm\":\"KICUKIRO\",\"sctrNm\":\"KAGARAMA\",\"locDesc\":null,\"mgrNm\":\"manage1130_01\",\"mgrTelNo\":\"0789011130\",\"mgrEmail\":\"manage113001@test.com\",\"hqYn\":\"N\"}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            BranchResponse testObject = new BranchResponse
            {
                Data = new BranchResponseData
                {
                    BranchList = new List<BranchInformation>
                    {
                        new BranchInformation
                        {
                            BranchOfficeID = "00",
                            BranchOfficeName = "Headquater",
                            BranchStatusCode = "01",
                            DistrictName = "GASABO",
                            HeadQuarter = "Y",
                            LocationDescription = null,
                            ManagerEmail = "manage113000@test.com",
                            ManagerName = "manage1130_00",
                            ManagerContactNumber = "0789001130",
                            ProvinceName = "KIGALI CITY",
                            SectorName = "KACYIRU",
                            Tin = "999991130"
                        },
                        new BranchInformation
                        {
                            BranchOfficeID = "01",
                            BranchOfficeName = "Branch01",
                            BranchStatusCode = "01",
                            DistrictName = "KICUKIRO",
                            HeadQuarter = "N",
                            LocationDescription = null,
                            ManagerEmail = "manage113001@test.com",
                            ManagerName = "manage1130_01",
                            ManagerContactNumber = "0789011130",
                            ProvinceName = "KIGALICITY",
                            SectorName = "KAGARAMA",
                            Tin = "999991130"
                        },
                    }
                },
                ResultCode = "000",
                ResultDate = "20200226193023",
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
            var json = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226193023\",\"data\":{\"bhfList\":[{\"tin\":\"999991130\",\"bhfId\":\"00\",\"bhfNm\":\"Headquater\",\"bhfSttsCd\":\"01\",\"prvncNm\":\"KIGALI CITY\",\"dstrtNm\":\"GASABO\",\"sctrNm\":\"KACYIRU\",\"locDesc\":null,\"mgrNm\":\"manage1130_00\",\"mgrTelNo\":\"0789001130\",\"mgrEmail\":\"manage113000@test.com\",\"hqYn\":\"Y\"},{\"tin\":\"999991130\",\"bhfId\":\"01\",\"bhfNm\":\"Branch01\",\"bhfSttsCd\":\"01\",\"prvncNm\":\"KIGALICITY\",\"dstrtNm\":\"KICUKIRO\",\"sctrNm\":\"KAGARAMA\",\"locDesc\":null,\"mgrNm\":\"manage1130_01\",\"mgrTelNo\":\"0789011130\",\"mgrEmail\":\"manage113001@test.com\",\"hqYn\":\"N\"}]}}"; 
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            BranchResponse? response = jsonSerializer.Deserialize<BranchResponse>(json);

            // Assert
            response.Should().NotBeNull();
            response!.Data.Should().NotBeNull();
            response.Data!.BranchList.Should().NotBeNullOrEmpty();
            response.Data.BranchList!.Count.Should().Be(2);


            response.Data.BranchList[0].BranchOfficeID.Should().Be("00");
            response.Data.BranchList[0].BranchOfficeName.Should().Be("Headquater");
            response.Data.BranchList[0].BranchStatusCode.Should().Be("01");
            response.Data.BranchList[0].DistrictName.Should().Be("GASABO");
            response.Data.BranchList[0].HeadQuarter.Should().Be("Y");
            response.Data.BranchList[0].LocationDescription.Should().BeNull();
            response.Data.BranchList[0].ManagerEmail.Should().Be("manage113000@test.com");
            response.Data.BranchList[0].ManagerName.Should().Be("manage1130_00");
            response.Data.BranchList[0].ManagerContactNumber.Should().Be("0789001130");
            response.Data.BranchList[0].ProvinceName.Should().Be("KIGALI CITY");
            response.Data.BranchList[0].SectorName.Should().Be("KACYIRU");
            response.Data.BranchList[0].Tin.Should().Be("999991130");

            response.ResultCode.Should().Be("000");
            response.ResultDate.Should().Be("20200226193023");
            response.ResultMessage.Should().Be("It is succeeded");
        }
    }
}
