using Ecommerce_Project.Models;
using Ecommerce_Project.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ProductsService productService;

        public ProductsController(ProductsService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")] // Specify route template with id parameter
        public IActionResult GetProductsById(int id)
        {
            var products= productService.FindProductById(id);
            return Ok(products);
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Products product)
        {
            productService.AddProduct(product);
            return CreatedAtAction(nameof(GetAllProducts), new { id = product.Id }, product);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct( int id)
        {
            productService.DeleteProduct(id);
            return NoContent();
        }

        [HttpPut("/updateroduct/{id}")]
        public IActionResult UpdateProduct( int id, [FromBody] Products updatedProduct)
        {
            if (id != updatedProduct.Id)
            {
                return BadRequest("Product ID mismatch");
            }

            productService.UpdateProduct(updatedProduct);
            return Ok(updatedProduct);
        }

       
    }
}