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
    public class CustomerResponseTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226192053\",\"data\":{\"custList\":[{\"tin\":\"841562115\",\"taxprNm\":\"TAXPAYER1\",\"taxprSttsCd\":\"A\",\"prvncNm\":\"KIGALI CITY\",\"dstrtNm\":\"KICUKIRO\",\"sctrNm\":\"KAGARAMA\",\"locDesc\":\"Kicukiro\"},{\"tin\":\"451848361\",\"taxprNm\":\"TAXPAYER2\",\"taxprSttsCd\":\"A\",\"prvncNm\":\"KIGALICITY\",\"dstrtNm\":\"KICUKIRO\",\"sctrNm\":\"KAGARAMA\",\"locDesc\":\"123-233\"}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            CustomerResponse testObject = new CustomerResponse
            {
                Data = new CustomerResponseData
                {
                    TaxpayerList = new List<TaxpayerInformation>
                    {
                        new TaxpayerInformation
                        {
                            DistrictName = "KICUKIRO",
                            LocationDescription = "Kicukiro",
                            ProvinceName = "KIGALI CITY",
                            SectorName = "KAGARAMA",
                            TaxpayerName = "TAXPAYER1",
                            TaxpayerStatusCode =  "A",
                            Tin = "841562115"
                        },
                        new TaxpayerInformation
                        {
                            DistrictName = "KICUKIRO",
                            LocationDescription = "123-233",
                            ProvinceName = "KIGALICITY",
                            SectorName = "KAGARAMA",
                            TaxpayerName = "TAXPAYER2",
                            TaxpayerStatusCode =  "A",
                            Tin = "451848361"
                        }
                    }
                },
                ResultCode = "000",
                ResultDate = "20200226192053",
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
            var json = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226192053\",\"data\":{\"custList\":[{\"tin\":\"841562115\",\"taxprNm\":\"TAXPAYER1\",\"taxprSttsCd\":\"A\",\"prvncNm\":\"KIGALI CITY\",\"dstrtNm\":\"KICUKIRO\",\"sctrNm\":\"KAGARAMA\",\"locDesc\":\"Kicukiro\"},{\"tin\":\"451848361\",\"taxprNm\":\"TAXPAYER2\",\"taxprSttsCd\":\"A\",\"prvncNm\":\"KIGALICITY\",\"dstrtNm\":\"KICUKIRO\",\"sctrNm\":\"KAGARAMA\",\"locDesc\":\"123-233\"}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            CustomerResponse? response = jsonSerializer.Deserialize<CustomerResponse>(json);

            // Assert
            response.Should().NotBeNull();
            response!.Data.Should().NotBeNull();
            response.Data!.TaxpayerList.Should().NotBeNullOrEmpty();
            response.Data.TaxpayerList!.Count.Should().Be(2);

            response.Data.TaxpayerList[0].DistrictName.Should().Be("KICUKIRO");
            response.Data.TaxpayerList[0].LocationDescription.Should().Be("Kicukiro");
            response.Data.TaxpayerList[0].ProvinceName.Should().Be("KIGALI CITY");
            response.Data.TaxpayerList[0].SectorName.Should().Be("KAGARAMA");
            response.Data.TaxpayerList[0].TaxpayerName.Should().Be("TAXPAYER1");
            response.Data.TaxpayerList[0].TaxpayerStatusCode.Should().Be("A");
            response.Data.TaxpayerList[0].Tin.Should().Be("841562115");

            response.ResultCode.Should().Be("000");
            response.ResultDate.Should().Be("20200226192053");
            response.ResultMessage.Should().Be("It is succeeded");
        }
    }
}
