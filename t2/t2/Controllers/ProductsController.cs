using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using t2.Data;
using t2.Model;

namespace t2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
            var product = _context.Products.ToList();
            return Ok(product);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody]Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProduct),new {id = product.ProductID},product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id , [FromBody] Product product)
        {
            var existingProduct = _context.Products.Find(id);
            if(existingProduct == null)return NotFound();

            existingProduct.NameProduct = product.NameProduct;
            existingProduct.PriceProduct = product.PriceProduct;
            existingProduct.DescriptionProduct = product.DescriptionProduct;
            //existingProduct.name = product.name;           
            //existingProduct.price = product.price;
            //existingProduct.category = product.category;
            //existingProduct.ingredients = product.ingredients;
            //existingProduct.price = product.price;
            //existingProduct.cost = product.cost;
            //existingProduct.seasonal_indicator = product.seasonal_indicator; 
            //existingProduct.active_status = product.active_status;
            //existingProduct.introduction_date = product.introduction_date; 

            _context.SaveChanges();
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var products = _context.Products.Find(id);
            if (products == null) return NotFound();

            _context.Products.Remove(products);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
