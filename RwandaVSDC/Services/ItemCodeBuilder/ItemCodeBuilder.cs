using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.ItemCodeBuilder
{
    public class ItemCodeBuilder : IItemCodeBuilder
    {
        private static int counter = 0; 
        public string CreateItemCode(string countryOfOrigin = "RW", string productType = "2", string packagingUnit = "NT", string quantityUnity = "BA", string? increment = null)
        {
            if (string.IsNullOrEmpty(increment))
            {
                increment = counter.ToString().PadLeft(7, '0');
            }
            return $"{countryOfOrigin}{productType}{packagingUnit}{quantityUnity}{increment}";
        }

        public static void Up()
        {
            counter++;
        }
    }
}
