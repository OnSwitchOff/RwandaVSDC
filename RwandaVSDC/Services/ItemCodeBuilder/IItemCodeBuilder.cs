namespace RwandaVSDC.Services.ItemCodeBuilder
{
    public interface IItemCodeBuilder
    {
        string CreateItemCode(string countryOfOrigin = "RW", string productType = "2", string packagingUnit = "NT", string quantityUnity = "BA", string increment = "0000001");
    }
}