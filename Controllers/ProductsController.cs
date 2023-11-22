using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Extensions;
using Product_Reviews_Api.Data;
using Product_Reviews_Api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Product_Reviews_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
            public ProductsController (ApplicationDbContext context)
            {
            _context = context; 
            }
        // GET: api/<ProductsController>
 //       [HttpGet]
 //       public IEnumerable<string> Get()
 //       {
 //           return new string[] { "value1", "value2" };
 //       }

        // GET api/<ProductsController>/5
 //       [HttpGet("{id}")]
 //       public string Get(int id)
 //       {
 //           return "value";
 //       }

        // POST api/<ProductsController>
        [HttpPost]
        public IActionResult ProductPost([FromBody] Product addProduct)
        {
            _context.Products.Add(addProduct);
            _context.SaveChanges();
            return StatusCode(201, addProduct);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public IActionResult ProductPut(int id, [FromBody] Product updatedProduct)
        {
            var updateProduct = _context.Products.Find(id);
            if (updateProduct==null)
            {
                return NotFound();
            }
            updateProduct.Name = updatedProduct.Name;
            updateProduct.Price = updatedProduct.Price;
            _context.Update(updateProduct);
            _context.SaveChanges();
            return StatusCode(200, updateProduct);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public IActionResult ProductDelete(int id)
        {
            var deleteProduct = _context.Products.Find(id);
            if (deleteProduct==null)
            {
                return NotFound();
            }
            _context.Products.Remove(deleteProduct);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
