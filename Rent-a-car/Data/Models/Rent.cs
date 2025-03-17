using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rent_a_car.Data.Models
{
    public class Rent
    {
        public int Id { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int CarId { get; set; }
        public Car? Car { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }
        public string Status { get; set; }
    }
}
