using Microsoft.AspNetCore.Mvc;
using Product_Reviews_Api.Data;
using Product_Reviews_Api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Product_Reviews_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<ReviewsController>
        [HttpGet]
        public IActionResult ReviewGet()
        {
            var getReview = _context.Reviews.ToList();
            return StatusCode(200,getReview);
        }

        // GET api/<ReviewsController>/5
        [HttpGet("{id}")]
        public IActionResult ReviewGet(int id)
        {
            var getReview = _context.Reviews.Find(id);
            if (getReview==null)
            {
                return NotFound();
            }

            return StatusCode(200,getReview);
        }

        // POST api/<ReviewsController>
        [HttpPost]
        public IActionResult ReviewPost([FromBody] Review addReview)
        {
            _context.Reviews.Add(addReview);
            _context.SaveChanges();
            return StatusCode(201,addReview);
        }

        // PUT api/<ReviewsController>/5
        [HttpPut("{id}")]
        public IActionResult ReviewPut(int id, [FromBody] Review updatedReview)
        {
            var updateReview = _context.Reviews.Find(id);
            if (updateReview==null)
            {
                return NotFound();
            }
            updateReview.Text = updatedReview.Text;
            updateReview.Rating = updatedReview.Rating;
            updateReview.ProductId = updatedReview.ProductId;
            _context.Update(updateReview);
            _context.SaveChanges();
            return StatusCode(200, updateReview);
        }

        // DELETE api/<ReviewsController>/5
        [HttpDelete("{id}")]
        public IActionResult ReviewDelete(int id)
        {
            var deleteReview = _context.Reviews.Find(id);
            if (deleteReview == null)
            {
                return NotFound();
            }
            _context.Reviews.Remove(deleteReview);
            _context.SaveChanges();
            return NoContent();
        }
        [Route("api/productId")]
        public IActionResult ReviewGetByProductId(ICollection <Review> Reviews, int productId)
        {
            var getByProdId = _context.Reviews.Where(r => r.ProductId==productId);
            return NotFound();
        }
    }
}
