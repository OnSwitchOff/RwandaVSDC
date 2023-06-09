﻿using FluentAssertions;
using RwandaVSDC.Models.JSON.ItemClass.SelectItemsClass;
using RwandaVSDC.Models.JSON.Branches.SelectBranches;
using RwandaVSDC.Services.JsonSerializer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RwandaVSDC.Test.ModelsTests.JSON.Branches.SelectBranches
{
    public class BranchRequestTests
    {
        [Fact]
        public void ShouldSerializeToJson()
        {
            // Arrange
            var expectedJson = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"lastReqDt\":\"20191130000000\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();
            BranchRequest testObject = new BranchRequest
            {
                Tin = "999991130",
                BranchId = "00",
                LastRequestDate = "20191130000000"
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
            var json = "{\"tin\":\"999991130\",\"bhfId\":\"00\",\"lastReqDt\":\"20191130000000\"}";
            IJsonSerializerService jsonSerializer = new JsonSerializerService();

            // Act
            BranchRequest? model = jsonSerializer.Deserialize<BranchRequest>(json);

            // Assert
            model.Should().NotBeNull();
            model!.Tin.Should().Be("999991130");
            model.BranchId.Should().Be("00");
            model.LastRequestDate.Should().Be("20191130000000");
        }
    }
}
