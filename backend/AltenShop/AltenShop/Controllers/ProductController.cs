using AltenShop.Data;
using AltenShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace AltenShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DataDBContext _context;

        public ProductController(DataDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            if (product == null)
            {
                return NotFound();
            }

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();

            return Ok(product);
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = _context.Products;

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);

            if(product== null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> EditProduct(int id, Product newProduct)
        {
            //var product = _context.Products.SingleOrDefault(p => p.Id == id);

            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }
            else
            {
                product.Code = newProduct.Code;
                product.Name = newProduct.Name;
                product.Description = newProduct.Description;
                product.Price = newProduct.Price;
                product.Quantity = newProduct.Quantity;
                product.InventoryStatus = newProduct.InventoryStatus;
                product.Category = newProduct.Category;
                product.Image = newProduct.Image;
                product.Rating = newProduct.Rating;

                await _context.SaveChangesAsync();
                return Ok(product);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if(id <= 0)
            {
                return BadRequest();
            }

            var product = _context.Products.SingleOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            _context.SaveChanges();

            return Ok(true);
        }

    }
}
