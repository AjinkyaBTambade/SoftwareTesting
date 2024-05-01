

using ProductCatalog;
using System.Text.Json;

List<Product> expectedProducts = new List<Product>();

expectedProducts.Add(new Product { Name = "Jasmine", Description = "Smelling Flower", Category = "flowers", StockAvailable = 4500, UnitPrice = 12 });
expectedProducts.Add(new Product { Name = "Rose", Description = "Smelling Flower", Category = "flowers", StockAvailable = 4500, UnitPrice = 12 });
expectedProducts.Add(new Product { Name = "Tulip", Description = "Smelling Flower", Category = "flowers", StockAvailable = 4500, UnitPrice = 12 });
expectedProducts.Add(new Product { Name = "Lotus", Description = "Smelling Flower", Category = "flowers", StockAvailable = 4500, UnitPrice = 12 });
expectedProducts.Add(new Product { Name = "Marigold", Description = "Smelling Flower", Category = "flowers", StockAvailable = 4500, UnitPrice = 12 });

// Act
HttpClient _client;
HttpClient _httpClient = new HttpClient();
string BaseUrl = "";

var response = await _httpClient.GetAsync(BaseUrl);
response.EnsureSuccessStatusCode();

var content = await response.Content.ReadAsStringAsync();
Console.WriteLine(content);

List<Product> resultProducts = JsonSerializer.Deserialize<List<Product>>(content);

foreach (Product p in resultProducts)
{
    Console.WriteLine(p.Name + "  " + p.Description + "  " + p.Category);
}