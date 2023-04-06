using FluentAssertions;
using RwandaVSDC.Models.JSON.Code.SelectCodes;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.JSON.Code.SelectCodes
{
    public class CodeResponseTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226143506\",\"data\":{\"clsList\":[{\"cdCls\":\"04\",\"cdClsNm\":\"Tax Type\",\"cdClsDesc\":null,\"useYn\":\"Y\",\"userDfnNm1\":\"Tax Rate\",\"userDfnNm2\":null,\"userDfnNm3\":null,\"dtlList\":[{\"cd\":\"A\",\"cdNm\":\"AEX\",\"cdDesc\":\"...\",\"useYn\":\"Y\",\"srtOrd\":1,\"userDfnCd1\":\"0\",\"userDfnCd2\":null,\"userDfnCd3\":null},{\"cd\":\"B\",\"cdNm\":\"B-18.00%\",\"cdDesc\":\"B18.00%\",\"useYn\":\"Y\",\"srtOrd\":2,\"userDfnCd1\":\"18\",\"userDfnCd2\":null,\"userDfnCd3\":null},{\"cd\":\"C\",\"cdNm\":\"C\",\"cdDesc\":\"C\",\"useYn\":\"Y\",\"srtOrd\":3,\"userDfnCd1\":\"0\",\"userDfnCd2\":null,\"userDfnCd3\":null},{\"cd\":\"D\",\"cdNm\":\"D\",\"cdDesc\":\"D\",\"useYn\":\"Y\",\"srtOrd\":4,\"userDfnCd1\":\"0\",\"userDfnCd2\":null,\"userDfnCd3\":null}]}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            CodeResponse testObject = new CodeResponse
            {
                ResultCode = "000",
                ResultMessage = "It is succeeded",
                ResultDate = "20200226143506",
                Data = new CodeResponseData
                {
                    ClsList = new List<CodeClassificationInformation>
                    {
                        new CodeClassificationInformation
                        {
                            CodeClass = "04",
                            CodeClassName = "Tax Type",
                            CodeClassDescription = null,
                            UseYesNo = "Y",
                            UserDefineName1 = "Tax Rate",
                            UserDefineName2 = null,
                            UserDefineName3 = null,
                            CodeDetailsInformationList = new List<CodeDetailsInformation>
                            {
                                new CodeDetailsInformation
                                {
                                    Code = "A",
                                    CodeName = "AEX",
                                    CodeDescription = "...",
                                    UseYesNo = "Y",
                                    SortOrder = 1,
                                    UserDefineCode1 = "0",
                                    UserDefineCode2 = null,
                                    UserDefineCode3 = null
                                },
                                new CodeDetailsInformation
                                {
                                    Code = "B",
                                    CodeName = "B-18.00%",
                                    CodeDescription = "B18.00%",
                                    UseYesNo = "Y",
                                    SortOrder = 2,
                                    UserDefineCode1 = "18",
                                    UserDefineCode2 = null,
                                    UserDefineCode3 = null
                                },
                                new CodeDetailsInformation
                                {
                                    Code = "C",
                                    CodeName = "C",
                                    CodeDescription = "C",
                                    UseYesNo = "Y",
                                    SortOrder = 3,
                                    UserDefineCode1 = "0",
                                    UserDefineCode2 = null,
                                    UserDefineCode3 = null
                                },
                                new CodeDetailsInformation
                                {
                                    Code = "D",
                                    CodeName = "D",
                                    CodeDescription = "D",
                                    UseYesNo = "Y",
                                    SortOrder = 4,
                                    UserDefineCode1 = "0",
                                    UserDefineCode2 = null,
                                    UserDefineCode3 = null
                                }
                            }
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
            var json = "{\"resultCd\":\"000\",\"resultMsg\":\"It is succeeded\",\"resultDt\":\"20200226143506\",\"data\":{\"clsList\":[{\"cdCls\":\"04\",\"cdClsNm\":\"Tax Type\",\"cdClsDesc\":null,\"useYn\":\"Y\",\"userDfnNm1\":\"Tax Rate\",\"userDfnNm2\":null,\"userDfnNm3\":null,\"dtlList\":[{\"cd\":\"A\",\"cdNm\":\"AEX\",\"cdDesc\":\"...\",\"useYn\":\"Y\",\"srtOrd\":1,\"userDfnCd1\":\"0\",\"userDfnCd2\":null,\"userDfnCd3\":null},{\"cd\":\"B\",\"cdNm\":\"B-18.00%\",\"cdDesc\":\"B18.00%\",\"useYn\":\"Y\",\"srtOrd\":2,\"userDfnCd1\":\"18\",\"userDfnCd2\":null,\"userDfnCd3\":null},{\"cd\":\"C\",\"cdNm\":\"C\",\"cdDesc\":\"C\",\"useYn\":\"Y\",\"srtOrd\":3,\"userDfnCd1\":\"0\",\"userDfnCd2\":null,\"userDfnCd3\":null},{\"cd\":\"D\",\"cdNm\":\"D\",\"cdDesc\":\"D\",\"useYn\":\"Y\",\"srtOrd\":4,\"userDfnCd1\":\"0\",\"userDfnCd2\":null,\"userDfnCd3\":null}]}]}}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            CodeResponse? model = jsonSerializer.Deserialize<CodeResponse>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Data.Should().NotBeNull();
            model.Data!.ClsList.Should().NotBeNullOrEmpty();
            model.Data.ClsList![0].CodeDetailsInformationList.Should().NotBeNullOrEmpty();
            model.Data.ClsList[0].CodeDetailsInformationList!.Count.Should().Be(4);


            model.ResultCode.Should().Be("000");
            model.ResultMessage.Should().Be("It is succeeded");
            model.ResultDate.Should().Be("20200226143506");

            model.Data.ClsList[0].CodeClass.Should().Be("04");
            model.Data.ClsList[0].CodeClassName.Should().Be("Tax Type");
            model.Data.ClsList[0].CodeClassDescription.Should().BeNull();
            model.Data.ClsList[0].UseYesNo.Should().Be("Y");
            model.Data.ClsList[0].UserDefineName1.Should().Be("Tax Rate");
            model.Data.ClsList[0].UserDefineName2.Should().BeNull();
            model.Data.ClsList[0].UserDefineName3.Should().BeNull();

            model.Data.ClsList[0].CodeDetailsInformationList![0].Code.Should().Be("A");
            model.Data.ClsList[0].CodeDetailsInformationList![0].CodeName.Should().Be("AEX");
            model.Data.ClsList[0].CodeDetailsInformationList![0].CodeDescription.Should().Be("...");
            model.Data.ClsList[0].CodeDetailsInformationList![0].UseYesNo.Should().Be("Y");
            model.Data.ClsList[0].CodeDetailsInformationList![0].SortOrder.Should().Be(1);
            model.Data.ClsList[0].CodeDetailsInformationList![0].UserDefineCode1.Should().Be("0");
            model.Data.ClsList[0].CodeDetailsInformationList![0].UserDefineCode2.Should().BeNull();
            model.Data.ClsList[0].CodeDetailsInformationList![0].UserDefineCode3.Should().BeNull();
        }
    }
}
