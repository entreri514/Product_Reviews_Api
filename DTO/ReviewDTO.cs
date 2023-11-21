using System.ComponentModel.DataAnnotations;

namespace Product_Reviews_Api.DTO
{
    public class ReviewDTO
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
    }
}
