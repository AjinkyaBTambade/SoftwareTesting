using Microsoft.AspNetCore.Mvc;
using ProductCatalog;

namespace ProductWebApplication.Controller
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            List<Product> products = ProductManager.GetProducts();
            return products;
        }


        
    }
}
