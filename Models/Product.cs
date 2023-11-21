using System.ComponentModel.DataAnnotations;

namespace Product_Reviews_Api.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Reviews ICollection<Review> { get; set; }
        
    }
}
