﻿using Microsoft.AspNetCore.Identity;

namespace Rent_a_car.Data.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string EGN { get; set; }
        public string PhoneNumber { get; set; }
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
        //?????????????????????????????????????????????????????????????????????
        //public IEnumerable<Car> Cars { get; init; } = new List<Car>();
    }
}
