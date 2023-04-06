﻿using FluentAssertions;
using RwandaVSDC.Models.Items.SelectItems;
using RwandaVSDC.Models.TransactionsPurchase.SelectTransactionsPurchaseSales;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.TransactionsPurchase.SelectTransactionsPurchaseSales
{
    public class TransactionsPurchaseSalesRequestTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"lastReqDt\":\"20180520000000\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            TransactionsPurchaseSalesRequest testObject = new TransactionsPurchaseSalesRequest
            {
                Tin = "999991130",
                BranchId = "00",
                LastRequestDate = "20180520000000"
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
            var json = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"lastReqDt\":\"20180520000000\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            TransactionsPurchaseSalesRequest? model = jsonSerializer.Deserialize<TransactionsPurchaseSalesRequest>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Tin.Should().Be("999991130");
            model.BranchId.Should().Be("00");
            model.LastRequestDate.Should().Be("20180520000000");
        }
    }
}
