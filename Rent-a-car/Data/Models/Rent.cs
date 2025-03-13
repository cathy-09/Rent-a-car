using System.ComponentModel.DataAnnotations;

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
        public int CusromerId { get; set; }
        public Customer? Customer { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
    }
}
