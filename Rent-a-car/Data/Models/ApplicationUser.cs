using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static Rent_a_car.Data.DataConstants.ApplicationUser;

namespace Rent_a_car.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(UserFirstNameMaxLength)]
        public string FirstName { get; set; } = null!;
        [MaxLength(UserMiddleNameMaxLength)]
        public string MiddleName { get; set; } = null!;
        [Required]
        [MaxLength(UserLastNameMaxLength)]
        public string LastName { get; set; } = null!;
    }
}
