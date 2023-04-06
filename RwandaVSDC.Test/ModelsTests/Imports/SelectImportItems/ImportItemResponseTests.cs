using FluentAssertions;
using RwandaVSDC.Models.Imports.SelectImportItems;
using RwandaVSDC.Models.Items.SelectItems;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.Imports.SelectImportItems
{
    public class ImportItemResponseTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226194118\",\"data\":{\"itemList\":[{\"taskCd\":\"2239078\",\"dclDe\":\"-1 \",\"itemSeq\":1,\"dclNo\":\"C3460-2019- TZDL\",\"hsCd\":\"20055900000\",\"itemNm\":\"BAKED BEANS\",\"imptItemsttsCd\":\"2\",\"orgnNatCd\":\"BR\",\"exptNatCd\":\"BR\",\"pkg\":2922,\"pkgUnitCd\":null,\"qty\":19946,\"qtyUnitCd\":\"KGM\",\"totWt\":19945.57,\"netWt\":19945.57,\"spplrNm\":\"ODERICH CONSERVA QUALIDADE\\nBRASIL\",\"agntNm\":\"BN METRO Ltd\",\"invcFcurAmt\":296865.6,\"invcFcurCd\":\"USD\",\"invcFcurExcrt\":929.79}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            ImportItemResponse testObject = new ImportItemResponse
            {
                ResultCode = "000",
                ResultDate = "20200226194118",
                ResultMessage = "It is succeeded",
                Data = new ImportItemResponseData
                {
                    ItemList = new List<ImportItemInformation>
                    {
                        new ImportItemInformation 
                        {
                            AgentName = "BN METRO Ltd",
                            DeclarationDate = "-1 ",
                            DeclarationNumber = "C3460-2019- TZDL",
                            ExportNationCode = "BR",
                            HSCode = "20055900000",
                            ImportItemStatusCode = "2",
                            InvoiceForeignCurrencyAmount = 296865.6m,
                            InvoiceForeignCurrency = "USD",
                            InvcFcurExcrt = 929.79m,
                            ItemName = "BAKED BEANS",
                            ItemSequence = 1,
                            NetWeight = 19945.57m,
                            OriginPlaceCode = "BR",
                            Package = 2922,
                            PackagingUnitCode = null,
                            Quantity = 19946,
                            QuantityUnitCode = "KGM",
                            SupplierName = "ODERICH CONSERVA QUALIDADE\nBRASIL",
                            TaskCode = "2239078",
                            GrossWeight = 19945.57m
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
            var json = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226194118\",\"data\":{\"itemList\":[{\"taskCd\":\"2239078\",\"dclDe\":\"-1 \",\"itemSeq\":1,\"dclNo\":\"C3460-2019- TZDL\",\"hsCd\":\"20055900000\",\"itemNm\":\"BAKED BEANS\",\"imptItemsttsCd\":\"2\",\"orgnNatCd\":\"BR\",\"exptNatCd\":\"BR\",\"pkg\":2922,\"pkgUnitCd\":null,\"qty\":19946,\"qtyUnitCd\":\"KGM\",\"totWt\":19945.57,\"netWt\":19945.57,\"spplrNm\":\"ODERICH CONSERVA QUALIDADE\\nBRASIL\",\"agntNm\":\"BN METRO Ltd\",\"invcFcurAmt\":296865.6,\"invcFcurCd\":\"USD\",\"invcFcurExcrt\":929.79}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            ImportItemResponse? model = jsonSerializer.Deserialize<ImportItemResponse>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Data.Should().NotBeNull();
            model.Data!.ItemList.Should().NotBeNullOrEmpty();

            model.ResultCode.Should().Be("000");
            model.ResultDate.Should().Be("20200226194118");
            model.ResultMessage.Should().Be("It is succeeded");

            model.Data.ItemList![0].AgentName.Should().Be("BN METRO Ltd");
            model.Data.ItemList[0].DeclarationDate.Should().Be("-1 ");
            model.Data.ItemList[0].DeclarationNumber.Should().Be("C3460-2019- TZDL");
            model.Data.ItemList[0].ExportNationCode.Should().Be("BR");
            model.Data.ItemList[0].HSCode.Should().Be("20055900000");
            model.Data.ItemList[0].ImportItemStatusCode.Should().Be("2");
            model.Data.ItemList[0].InvoiceForeignCurrencyAmount.Should().Be(296865.6m);
            model.Data.ItemList[0].InvoiceForeignCurrency.Should().Be("USD");
            model.Data.ItemList[0].InvcFcurExcrt.Should().Be(929.79m);
            model.Data.ItemList[0].ItemName.Should().Be("BAKED BEANS");
            model.Data.ItemList[0].ItemSequence.Should().Be(1);
            model.Data.ItemList[0].NetWeight.Should().Be(19945.57m);
            model.Data.ItemList[0].OriginPlaceCode.Should().Be("BR");
            model.Data.ItemList[0].Package.Should().Be(2922);
            model.Data.ItemList[0].PackagingUnitCode.Should().BeNull();
            model.Data.ItemList[0].Quantity.Should().Be(19946);
            model.Data.ItemList[0].QuantityUnitCode.Should().Be("KGM");
            model.Data.ItemList[0].SupplierName.Should().Be("ODERICH CONSERVA QUALIDADE\nBRASIL");
            model.Data.ItemList[0].TaskCode.Should().Be("2239078");
            model.Data.ItemList[0].GrossWeight.Should().Be(19945.57m);
        }
    }
}

