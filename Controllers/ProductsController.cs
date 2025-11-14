using Microsoft.AspNetCore.Mvc;
using LibraryAPI_WithDummyData.Models;

namespace LibraryAPI_WithDummyData.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase {

        private static List<Product> _products = new(){
            new Product{ProductId=1,Name="Notebook",SKU="NB001",Price=50,QuantityInStock=100},
            new Product{ProductId=2,Name="Pen",SKU="PN002",Price=10,QuantityInStock=500}
        };

        [HttpGet]
        public IActionResult GetAll() => Ok(_products);
    }
}