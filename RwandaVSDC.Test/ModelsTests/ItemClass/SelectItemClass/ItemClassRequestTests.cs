﻿using FluentAssertions;
using RwandaVSDC.Models.Initialization.SelectInitInfo;
using RwandaVSDC.Models.ItemClass.SelectItemsClass;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.ItemClass.SelectItemClass
{
    public class ItemClassRequestTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"lastReqDt\":\"20180523000000\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            ItemClassRequest testObject = new ItemClassRequest
            {
                Tin = "999991130",
                BranchId = "00",
                LastRequestDate = "20180523000000"
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
            var json = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"lastReqDt\":\"20180523000000\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            ItemClassRequest? model = jsonSerializer.Deserialize<ItemClassRequest>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Tin.Should().Be("999991130");
            model.BranchId.Should().Be("00");
            model.LastRequestDate.Should().Be("20180523000000");
        }
    }
}
