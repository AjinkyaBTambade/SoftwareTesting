using System.Text.Json.Serialization;

namespace ProductCatalog
{
    [Serializable]
    public class Product : IComparable
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("category")]
        public string Category { get; set; }
        [JsonPropertyName("stockavailable")]
        public int StockAvailable {  get; set; }
        [JsonPropertyName("unitprice")]
        public float UnitPrice {  get; set; }
        public int CompareTo(object? obj)
        {
            Product product = obj as Product;
            return product.StockAvailable.CompareTo(StockAvailable);
        }
    }
}
