using Microsoft.AspNetCore.Identity;

namespace Rent_a_car.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EGN { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string NetUserId { get; set; } = null!;
        public IdentityUser NetUser { get; set; } = null!;
    }
}
