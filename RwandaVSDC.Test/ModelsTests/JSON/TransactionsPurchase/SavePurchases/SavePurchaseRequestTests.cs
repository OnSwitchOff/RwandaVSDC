using FluentAssertions;
using RwandaVSDC.Models.JSON.TransactionsPurchase.SavePurchases;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.TransactionsPurchase.SavePurchases
{
    public class SavePurchaseRequestTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"invcNo\":1,\"orgInvcNo\":0,\"spplrTin\":null,\"spplrBhfId\":null,\"spplrNm\":null,\"spplrInvcNo\":null,\"regTyCd\":\"M\",\"pchsTyCd\":\"N\",\"rcptTyCd\":\"P\",\"pmtTyCd\":\"01\",\"pchsSttsCd\":\"02\",\"cfmDt\":\"20200127210300\",\"pchsDt\":\"20200127\",\"wrhsDt\":\"\",\"cnclReqDt\":\"\",\"cnclDt\":\"\",\"rfdDt\":\"\",\"totItemCnt\":2,\"taxblAmtA\":0,\"taxblAmtB\":10500,\"taxblAmtC\":0,\"taxblAmtD\":0,\"taxRtA\":0,\"taxRtB\":18,\"taxRtC\":0,\"taxRtD\":0,\"taxAmtA\":0,\"taxAmtB\":1890,\"taxAmtC\":0,\"taxAmtD\":0,\"totTaxblAmt\":10500,\"totTaxAmt\":1890,\"totAmt\":10500,\"remark\":null,\"regrNm\":\"Admin\",\"regrId\":\"Admin\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\",\"itemList\":[{\"itemSeq\":1,\"itemCd\":\"RW1NTXU0000001\",\"itemClsCd\":\"5059690800\",\"itemNm\":\"test item 1\",\"bcd\":\"\",\"spplrItemClsCd\":null,\"spplrItemCd\":null,\"spplrItemNm\":null,\"pkgUnitCd\":\"NT\",\"pkg\":2,\"qtyUnitCd\":\"U\",\"qty\":2,\"prc\":3500,\"splyAmt\":7000,\"dcRt\":0,\"dcAmt\":0,\"taxblAmt\":7000,\"taxTyCd\":\"B\",\"taxAmt\":1260,\"totAmt\":7000,\"itemExprDt\":null},{\"itemSeq\":2,\"itemCd\":\"RW1NTXU0000002\",\"itemClsCd\":\"5022110801\",\"itemNm\":\"test item 2\",\"bcd\":\"\",\"spplrItemClsCd\":null,\"spplrItemCd\":null,\"spplrItemNm\":null,\"pkgUnitCd\":\"NT\",\"pkg\":1,\"qtyUnitCd\":\"U\",\"qty\":1,\"prc\":3500,\"splyAmt\":3500,\"dcRt\":0,\"dcAmt\":0,\"taxblAmt\":3500,\"taxTyCd\":\"B\",\"taxAmt\":630,\"totAmt\":3500,\"itemExprDt\":null}]}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            SavePurchaseRequest testObject = new SavePurchaseRequest
            {
                Tin = "999991130",
                BranchId = "00",
                InvoiceNumber = 1,
                OriginalInvoiceNumber = 0,
                SupplierTin = null,
                SupplierBranchId = null,
                SupplierName = null,
                SupplierInvoiceNumber = null,                
                RegistrationTypeCode = "M",
                PurchaseTypeCode = "N",
                ReceiptTypeCode = "P",
                PaymentTypeCode = "01",
                PurchaseStatusCode = "02",
                ValidatedDate = "20200127210300",
                PurchaseDate = "20200127",
                WarehousingDate = "",
                CancelReqeuestedDate = "",
                CanceledDate = "",
                RefundedDate = "",
                TotalItemCount = 2,
                TaxableAmountA = 0,
                TaxableAmountB = 10500,
                TaxableAmountC = 0,
                TaxableAmountD = 0,
                TaxRateA = 0,
                TaxRateB = 18,
                TaxRateC = 0,
                TaxRateD = 0,
                TaxAmtA = 0,
                TaxAmtB = 1890,
                TaxAmtC = 0,
                TaxAmtD = 0,
                TotalTaxableAmount = 10500,
                TotalTaxAmount = 1890,
                TotalAmount = 10500,
                Remark = null,
                RegistrantName = "Admin",
                RegistrantId = "Admin",
                ModifierName = "Admin",
                ModifierId = "Admin",
                ItemList = new List<SavePurchaseRequestItemInfo>
                {
                    new SavePurchaseRequestItemInfo
                    {
                        ItemSequenceNumber = 1,
                        ItemCode = "RW1NTXU0000001",
                        ItemClassificationCode = "5059690800",
                        ItemName = "test item 1",
                        Barcode = "",
                        SupplierItemClassificationCode = null,
                        SupplierItemCode = null,
                        SupplierItemName = null,
                        PackagingUnitCode = "NT",
                        Package = 2,
                        QuantityUnitCode = "U",
                        Quantity = 2,
                        UnitPrice = 3500,
                        SupplyAmount = 7000,
                        DiscountRate = 0,
                        DiscountAmount = 0,
                        TaxableAmount = 7000,
                        TaxationTypeCode = "B",
                        TaxAmount = 1260,
                        TotalAmount = 7000,
                        ItemExpiredDate = null
                    },
                    new SavePurchaseRequestItemInfo
                    {
                        ItemSequenceNumber = 2,
                        ItemCode = "RW1NTXU0000002",
                        ItemClassificationCode = "5022110801",
                        ItemName = "test item 2",
                        Barcode = "",
                        SupplierItemClassificationCode = null,
                        SupplierItemCode = null,
                        SupplierItemName = null,
                        PackagingUnitCode = "NT",
                        Package = 1,
                        QuantityUnitCode = "U",
                        Quantity = 1,
                        UnitPrice = 3500,
                        SupplyAmount = 3500,
                        DiscountRate = 0,
                        DiscountAmount = 0,
                        TaxableAmount = 3500,
                        TaxationTypeCode = "B",
                        TaxAmount = 630,
                        TotalAmount = 3500,
                        ItemExpiredDate = null
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
            var json = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"invcNo\":1,\"orgInvcNo\":0,\"spplrTin\":null,\"spplrBhfId\":null,\"spplrNm\":null,\"spplrInvcNo\":null,\"regTyCd\":\"M\",\"pchsTyCd\":\"N\",\"rcptTyCd\":\"P\",\"pmtTyCd\":\"01\",\"pchsSttsCd\":\"02\",\"cfmDt\":\"20200127210300\",\"pchsDt\":\"20200127\",\"wrhsDt\":\"\",\"cnclReqDt\":\"\",\"cnclDt\":\"\",\"rfdDt\":\"\",\"totItemCnt\":2,\"taxblAmtA\":0,\"taxblAmtB\":10500,\"taxblAmtC\":0,\"taxblAmtD\":0,\"taxRtA\":0,\"taxRtB\":18,\"taxRtC\":0,\"taxRtD\":0,\"taxAmtA\":0,\"taxAmtB\":1890,\"taxAmtC\":0,\"taxAmtD\":0,\"totTaxblAmt\":10500,\"totTaxAmt\":1890,\"totAmt\":10500,\"remark\":null,\"regrNm\":\"Admin\",\"regrId\":\"Admin\",\"modrNm\":\"Admin\",\"modrId\":\"Admin\",\"itemList\":[{\"itemSeq\":1,\"itemCd\":\"RW1NTXU0000001\",\"itemClsCd\":\"5059690800\",\"itemNm\":\"test item 1\",\"bcd\":\"\",\"spplrItemClsCd\":null,\"spplrItemCd\":null,\"spplrItemNm\":null,\"pkgUnitCd\":\"NT\",\"pkg\":2,\"qtyUnitCd\":\"U\",\"qty\":2,\"prc\":3500,\"splyAmt\":7000,\"dcRt\":0,\"dcAmt\":0,\"taxblAmt\":7000,\"taxTyCd\":\"B\",\"taxAmt\":1260,\"totAmt\":7000,\"itemExprDt\":null},{\"itemSeq\":2,\"itemCd\":\"RW1NTXU0000002\",\"itemClsCd\":\"5022110801\",\"itemNm\":\"test item 2\",\"bcd\":\"\",\"spplrItemClsCd\":null,\"spplrItemCd\":null,\"spplrItemNm\":null,\"pkgUnitCd\":\"NT\",\"pkg\":1,\"qtyUnitCd\":\"U\",\"qty\":1,\"prc\":3500,\"splyAmt\":3500,\"dcRt\":0,\"dcAmt\":0,\"taxblAmt\":3500,\"taxTyCd\":\"B\",\"taxAmt\":630,\"totAmt\":3500,\"itemExprDt\":null}]}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            SavePurchaseRequest? model = jsonSerializer.Deserialize<SavePurchaseRequest>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Tin.Should().Be("999991130");
            model.BranchId.Should().Be("00");
            model.InvoiceNumber.Should().Be((BigInteger)1);
            model.OriginalInvoiceNumber.Should().Be((BigInteger)0);
            model.SupplierTin.Should().BeNull();
            model.SupplierBranchId.Should().BeNull();
            model.SupplierName.Should().BeNull();
            model.SupplierInvoiceNumber.Should().BeNull();
            model.RegistrationTypeCode.Should().Be("M");
            model.PurchaseTypeCode.Should().Be("N");
            model.ReceiptTypeCode.Should().Be("P");
            model.PaymentTypeCode.Should().Be("01");
            model.PurchaseStatusCode.Should().Be("02");
            model.ValidatedDate.Should().Be("20200127210300");
            model.PurchaseDate.Should().Be("20200127");
            model.WarehousingDate.Should().Be("");
            model.CancelReqeuestedDate.Should().Be("");
            model.CanceledDate.Should().Be("");
            model.RefundedDate.Should().Be("");
            model.TotalItemCount.Should().Be(2);
            model.TaxableAmountA.Should().Be(0);
            model.TaxableAmountB.Should().Be(10500);
            model.TaxableAmountC.Should().Be(0);
            model.TaxableAmountD.Should().Be(0);
            model.TaxRateA.Should().Be(0);
            model.TaxRateB.Should().Be(18);
            model.TaxRateC.Should().Be(0);
            model.TaxRateD.Should().Be(0);
            model.TaxAmtA.Should().Be(0);
            model.TaxAmtB.Should().Be(1890);
            model.TaxAmtC.Should().Be(0);
            model.TaxAmtD.Should().Be(0);
            model.TotalTaxableAmount.Should().Be(10500);
            model.TotalTaxAmount.Should().Be(1890);
            model.TotalAmount.Should().Be(10500);
            model.Remark.Should().BeNull();
            model.RegistrantName.Should().Be("Admin");
            model.RegistrantId.Should().Be("Admin");
            model.ModifierId.Should().Be("Admin");
            model.ModifierName.Should().Be("Admin");
            model.ItemList.Should().NotBeNullOrEmpty();
            model.ItemList![0].ItemSequenceNumber.Should().Be(1);
            model.ItemList[0].ItemCode.Should().Be("RW1NTXU0000001");
            model.ItemList[0].ItemClassificationCode.Should().Be("5059690800");
            model.ItemList[0].ItemName.Should().Be("test item 1");
            model.ItemList[0].Barcode.Should().Be("");
            model.ItemList[0].SupplierItemClassificationCode.Should().BeNull();
            model.ItemList[0].SupplierItemCode.Should().BeNull();
            model.ItemList[0].SupplierItemName.Should().BeNull();
            model.ItemList[0].PackagingUnitCode.Should().Be("NT");
            model.ItemList[0].Package.Should().Be(2);
            model.ItemList[0].QuantityUnitCode.Should().Be("U");
            model.ItemList[0].Quantity.Should().Be(2);
            model.ItemList[0].UnitPrice.Should().Be(3500);
            model.ItemList[0].SupplyAmount.Should().Be(7000);
            model.ItemList[0].DiscountRate.Should().Be(0);
            model.ItemList[0].DiscountAmount.Should().Be(0);
            model.ItemList[0].TaxableAmount.Should().Be(7000);
            model.ItemList[0].TaxationTypeCode.Should().Be("B");
            model.ItemList[0].TaxAmount.Should().Be(1260);
            model.ItemList[0].TotalAmount.Should().Be(7000);
            model.ItemList[0].ItemExpiredDate.Should().BeNull();
        }
    }
}
