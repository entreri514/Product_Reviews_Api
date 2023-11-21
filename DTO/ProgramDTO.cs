using System.ComponentModel.DataAnnotations;

namespace Product_Reviews_Api.DTO
{
    public class ProgramDTO
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ICollection<ReviewDTO> Reviews { get; set; }
        public double AverageRating { get; set; }
    }
}
