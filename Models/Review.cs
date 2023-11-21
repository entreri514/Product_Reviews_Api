using System.ComponentModel.DataAnnotations.Schema;

namespace Product_Reviews_Api.Models
{
    public class Review
    {
        [ForeignKey]
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
