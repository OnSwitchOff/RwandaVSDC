using FluentAssertions;
using RwandaVSDC.Models.Items.SaveItems;
using RwandaVSDC.Models.Items.SelectItems;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.Items.SelectItems
{
    public class ItemResponseTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226193501\",\"data\":{\"itemList\":[{\"tin\":\"999991130\",\"itemCd\":\"KR2AMXBLL0000001\",\"itemClsCd\":\"1110160600\",\"itemTyCd\":\"2\",\"itemNm\":\"restitem#1\",\"itemStdNm\":null,\"orgnNatCd\":\"KR\",\"pkgUnitCd\":\"AM\",\"qtyUnitCd\":\"BLL\",\"taxTyCd\":\"B\",\"btchNo\":null,\"regBhfId\":\"00\",\"bcd\":\"8801234567061\",\"dftPrc\":21000,\"grpPrcL1\":0,\"grpPrcL2\":0,\"grpPrcL3\":0,\"grpPrcL4\":0,\"grpPrcL5\":0,\"addInfo\":null,\"sftyQty\":0,\"isrcAplcbYn\":\"N\",\"rraModYn\":\"N\",\"useYn\":\"Y\"},{\"tin\":\"999991130\",\"itemCd\":\"KR2AMXCAX0000001\",\"itemClsCd\":\"1110170400\",\"itemTyCd\":\"2\",\"itemNm\":\"coke1\",\"itemStdNm\":null,\"orgnNatCd\":\"KR\",\"pkgUnitCd\":\"AM\",\"qtyUnitCd\":\"CA\",\"taxTyCd\":\"B\",\"btchNo\":null,\"regBhfId\":\"00\",\"bcd\":\"8801234567891\",\"dftPrc\":5000,\"grpPrcL1\":0,\"grpPrcL2\":0,\"grpPrcL3\":0,\"grpPrcL4\":0,\"grpPrcL5\":0,\"addInfo\":null,\"sftyQty\":0,\"isrcAplcbYn\":\"Y\",\"rraModYn\":\"N\",\"useYn\":\"Y\"}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            ItemResponse testObject = new ItemResponse
            {
                ResultCode = "000",
                ResultDate = "20200226193501",
                ResultMessage = "It is succeeded",
                Data = new ItemResponseData
                {
                    ItemList = new List<ItemInformation>
                    {
                        new ItemInformation
                        {
                            AdditionalInformation = null,
                            Barcode = "8801234567061",
                            BatchNumber = null,
                            DefaultUnitPrice = 21000,
                            Group1UnitPrice = 0,
                            Group2UnitPrice = 0,
                            Group3UnitPrice = 0,
                            Group4UnitPrice = 0,
                            Group5UnitPrice = 0,
                            InsuranceAppicableYesNo = "N",
                            ItemCode = "KR2AMXBLL0000001",
                            ItemClassificationCode = "1110160600",
                            ItemName = "restitem#1",
                            ItemStandardName = null,
                            ItemTypeCode = "2",
                            OriginPlaceCode = "KR",
                            PackagingUnitCode = "AM",
                            QuantityUnitCode = "BLL",
                            RegistBranchOfficeID = "00",
                            RRAModifyYesNo = "N",
                            SaftyQuantity = 0,
                            TaxationTypeCode = "B",
                            Tin = "999991130",
                            UsedYesNo = "Y"
                        },
                        new ItemInformation
                        {
                            AdditionalInformation = null,
                            Barcode = "8801234567891",
                            BatchNumber = null,
                            DefaultUnitPrice = 5000,
                            Group1UnitPrice = 0,
                            Group2UnitPrice = 0,
                            Group3UnitPrice = 0,
                            Group4UnitPrice = 0,
                            Group5UnitPrice = 0,
                            InsuranceAppicableYesNo = "Y",
                            ItemCode = "KR2AMXCAX0000001",
                            ItemClassificationCode = "1110170400",
                            ItemName = "coke1",
                            ItemStandardName = null,
                            ItemTypeCode = "2",
                            OriginPlaceCode = "KR",
                            PackagingUnitCode = "AM",
                            QuantityUnitCode = "CA",
                            RegistBranchOfficeID = "00",
                            RRAModifyYesNo = "N",
                            SaftyQuantity = 0,
                            TaxationTypeCode = "B",
                            Tin = "999991130",
                            UsedYesNo = "Y"
                        }
                    }
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
            var json = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226193501\",\"data\":{\"itemList\":[{\"tin\":\"999991130\",\"itemCd\":\"KR2AMXBLL0000001\",\"itemClsCd\":\"1110160600\",\"itemTyCd\":\"2\",\"itemNm\":\"restitem#1\",\"itemStdNm\":null,\"orgnNatCd\":\"KR\",\"pkgUnitCd\":\"AM\",\"qtyUnitCd\":\"BLL\",\"taxTyCd\":\"B\",\"btchNo\":null,\"regBhfId\":\"00\",\"bcd\":\"8801234567061\",\"dftPrc\":21000,\"grpPrcL1\":0,\"grpPrcL2\":0,\"grpPrcL3\":0,\"grpPrcL4\":0,\"grpPrcL5\":0,\"addInfo\":null,\"sftyQty\":0,\"isrcAplcbYn\":\"N\",\"rraModYn\":\"N\",\"useYn\":\"Y\"},{\"tin\":\"999991130\",\"itemCd\":\"KR2AMXCAX0000001\",\"itemClsCd\":\"1110170400\",\"itemTyCd\":\"2\",\"itemNm\":\"coke1\",\"itemStdNm\":null,\"orgnNatCd\":\"KR\",\"pkgUnitCd\":\"AM\",\"qtyUnitCd\":\"CA\",\"taxTyCd\":\"B\",\"btchNo\":null,\"regBhfId\":\"00\",\"bcd\":\"8801234567891\",\"dftPrc\":5000,\"grpPrcL1\":0,\"grpPrcL2\":0,\"grpPrcL3\":0,\"grpPrcL4\":0,\"grpPrcL5\":0,\"addInfo\":null,\"sftyQty\":0,\"isrcAplcbYn\":\"Y\",\"rraModYn\":\"N\",\"useYn\":\"Y\"}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            ItemResponse? model = jsonSerializer.Deserialize<ItemResponse>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Data.Should().NotBeNull();
            model.Data!.ItemList.Should().NotBeNullOrEmpty();

            model.ResultCode.Should().Be("000");
            model.ResultDate.Should().Be("20200226193501");
            model.ResultMessage.Should().Be("It is succeeded");


            model.Data.ItemList![0].AdditionalInformation.Should().BeNull();
            model.Data.ItemList![0].Barcode.Should().Be("8801234567061");
            model.Data.ItemList![0].BatchNumber.Should().BeNull();
            model.Data.ItemList![0].DefaultUnitPrice.Should().Be(21000);
            model.Data.ItemList![0].Group1UnitPrice.Should().Be(0);
            model.Data.ItemList![0].Group2UnitPrice.Should().Be(0);
            model.Data.ItemList![0].Group3UnitPrice.Should().Be(0);
            model.Data.ItemList![0].Group4UnitPrice.Should().Be(0);
            model.Data.ItemList![0].Group5UnitPrice.Should().Be(0);
            model.Data.ItemList![0].InsuranceAppicableYesNo.Should().Be("N");
            model.Data.ItemList![0].ItemCode.Should().Be("KR2AMXBLL0000001");
            model.Data.ItemList![0].ItemClassificationCode.Should().Be("1110160600");
            model.Data.ItemList![0].ItemName.Should().Be("restitem#1");
            model.Data.ItemList![0].ItemStandardName.Should().BeNull();
            model.Data.ItemList![0].ItemTypeCode.Should().Be("2");
            model.Data.ItemList![0].OriginPlaceCode.Should().Be("KR");
            model.Data.ItemList![0].PackagingUnitCode.Should().Be("AM");
            model.Data.ItemList![0].QuantityUnitCode.Should().Be("BLL");
            model.Data.ItemList![0].RegistBranchOfficeID.Should().Be("00");
            model.Data.ItemList![0].RRAModifyYesNo.Should().Be("N");
            model.Data.ItemList![0].SaftyQuantity.Should().Be(0);
            model.Data.ItemList![0].TaxationTypeCode.Should().Be("B");
            model.Data.ItemList![0].Tin.Should().Be("999991130");
            model.Data.ItemList![0].UsedYesNo.Should().Be("Y");

        }
    }
}

