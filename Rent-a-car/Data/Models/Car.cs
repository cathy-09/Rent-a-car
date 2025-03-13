using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rent_a_car.Data.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        public int Year { get; set; }
        public int Seats { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(0, 2000)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}
