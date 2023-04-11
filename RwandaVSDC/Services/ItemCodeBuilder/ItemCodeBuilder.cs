using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RwandaVSDC.Services.ItemCodeBuilder
{
    public class ItemCodeBuilder : IItemCodeBuilder
    {
        public string CreateItemCode(string countryOfOrigin = "RW", string productType = "2", string packagingUnit = "NT", string quantityUnity = "BA", string increment = "0000001")
        {
            return $"{countryOfOrigin}{productType}{packagingUnit}{quantityUnity}{increment}";
        }
    }
}
