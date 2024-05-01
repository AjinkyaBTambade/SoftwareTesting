using ProductCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProductApp
{
    public class ProManager
    {
        public async Task Get_ReturnsSuccessStatus()
        {
            // Arrange
            List<Product> expectedProducts = new List<Product>();


            // Act
            HttpClient _client;
            HttpClient _httpClient = new HttpClient();
            string BaseUrl = "";

            var response = await _httpClient.GetAsync(BaseUrl);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            List<Product> resultProducts = JsonSerializer.Deserialize<List<Product>>(content);
            foreach (Product p in resultProducts)
            {
                Console.WriteLine(p.Name + " " + p.Description + " " + p.StockAvailable + " " + p.UnitPrice);
            }
        }
    }
}
