using Crm.Application.Products;
using Crm.Application.Products.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Crm_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
            var product = _productService.GetProducts();
            return Ok(product);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(Guid id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
                return NotFound("product not found");

            return Ok(product);
        }
        [HttpPost]
        public IActionResult AddProducts(AddProductDto product)
        {
            var result = _productService.AddProduct(product);
            var url = Url.Action(nameof(GetProductById), "Product", new { id = result }, Request.Scheme);
            return Created(url, result);
        }

        [HttpPut]
        public IActionResult EditProduct(EditProductDto product)
        {
            _productService.EditProduct(product);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(Guid id)
        {
            _productService.DeleteProductById(id);
            return Ok();
        }
    }
}
