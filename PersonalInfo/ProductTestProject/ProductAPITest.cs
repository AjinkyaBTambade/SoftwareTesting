using ProductCatalog;
using System.Text.Json;

namespace ProductTestProject
{
    public class ProductAPITest
    {
        private const string BaseUrl = "https://localhost:7101/product";
        private readonly HttpClient _httpClient;

        public ProductAPITest()
        {
            _httpClient = new HttpClient();
        }
        [Fact]
        public async Task GetResponse()
        {
            List<Product> expected = new List<Product>();
            expected.Add(new Product { Name = "Jasmine", Description = "Smelling Flower", Category = "flowers", StockAvailable = 4500, UnitPrice = 12 });
            expected.Add(new Product { Name = "Rose", Description = "Smelling Flower", Category = "flowers", StockAvailable = 4500, UnitPrice = 12 });
            expected.Add(new Product { Name = "Tulip", Description = "Smelling Flower", Category = "flowers", StockAvailable = 4500, UnitPrice = 12 });
            expected.Add(new Product { Name = "Lotus", Description = "Smelling Flower", Category = "flowers", StockAvailable = 4500, UnitPrice = 12 });
            expected.Add(new Product { Name = "Marigold", Description = "Smelling Flower", Category = "flowers", StockAvailable = 4500, UnitPrice = 12 });
           

            var response = await _httpClient.GetAsync(BaseUrl);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            List<Product> resultProduct = JsonSerializer.Deserialize<List<Product>>(content);

            Assert.Equal(expected, resultProduct);

        }
    }
}