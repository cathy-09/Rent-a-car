using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rent_a_car.Data.Models;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;

namespace Rent_a_car.Data
{
    public class RentACarDbContext : IdentityDbContext
    {
        public RentACarDbContext(DbContextOptions<RentACarDbContext> options)
            : base(options)
        {
        }
        private ApplicationUser Admin { get; set; }
        private ApplicationUser Guest { get; set; }
        private Customer Customer { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Rent> Rents { get; set; }
        private Car CarOne { get; set; }
        private Car CarTwo { get; set; }
        private Car CarThree { get; set; }
        private Rent RentOne { get; set; }
        private Rent RentTwo { get; set; }
        private Rent RentThree { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Rent>()
            .HasOne(r => r.Car)
            .WithMany(c => c.Rents)
            .HasForeignKey(r => r.CarId)
            .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Rent>()
            .HasOne(r => r.Customer)
            .WithMany(c => c.Rents)
            .HasForeignKey(r => r.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

            SeedUsers();
            builder.Entity<ApplicationUser>()
                .HasData(Admin, Guest);

            SeedCustomer();
            builder.Entity<Customer>()
                .HasData(Customer);

            SeedCars();
            builder.Entity<Car>()
                .HasData(CarOne, CarTwo, CarThree);

            SeedRents();
            builder.Entity<Rent>()
                .HasData(RentOne, RentTwo, RentThree);
        }
        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            Admin = new ApplicationUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "admin@mail.com",
                NormalizedUserName = "admin@mail.com",
                Email = "admin@mail.com",
                NormalizedEmail = "admin@mail.com",
                FirstName = "Great",
                MiddleName = "Admin",
                LastName = "One"
            };
            Admin.PasswordHash =
            hasher.HashPassword(Admin, "admin123");


            Guest = new ApplicationUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com",
                FirstName = "Ralitsa",
                MiddleName = "Stanimirova",
                LastName = "Stoilova"
            };
            Guest.PasswordHash =
            hasher.HashPassword(Guest, "guest123");
        }
        private void SeedCustomer()
        {
            Customer = new Customer()
            {
                Id = 1,
                EGN = "0642276633",
                PhoneNumber = "0888123456",
                UserId = Admin.Id
            };
        }
        private void SeedCars()
        {
            CarOne = new Car()
            {
                Id = 1,
                Brand = "Tesla",
                Model = "Model S",
                Year = 2023,
                Seats = 5,
                Description = "Electric sedan with high performance and advanced technology.",
                Price = 79999.99m,
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAghjhrXWTAGuaZ6Pnq6f3YfZdgm-3fcV31Q&s"
            };

            CarTwo = new Car()
            {
                Id = 2,
                Brand = "BMW",
                Model = "M3",
                Year = 2022,
                Seats = 5,
                Description = "Sporty sedan with a powerful engine and luxury features.",
                Price = 71999.99m,
                Image = "https://myve.bg/f/news/o/53/bf8c1ae97cf411da8e311d53d352ed02.jpeg"
            };

            CarThree = new Car()
            {
                Id = 3,
                Brand = "Toyota",
                Model = "Camry",
                Year = 2021,
                Seats = 5,
                Description = "Reliable and fuel-efficient sedan, perfect for daily commuting.",
                Price = 24999.99m,
                Image = "https://scene7.toyota.eu/is/image/toyotaeurope/CAM0001a_24_WEB:Large-Landscape?ts=1730967765830&resMode=sharp2&op_usm=1.75,0.3,2,0&fmt=png-alpha"
            };
        }
        private void SeedRents()
        {
            RentOne = new Rent()
            {
                Id = 1,
                StartDate = new DateTime(2025, 3, 10),
                EndDate = new DateTime(2025, 3, 15),
                CarId = CarOne.Id,
                CustomerId = Customer.Id,
                Total = 250,
                Status = "активна"
            };

            RentTwo = new Rent()
            {
                Id = 2,
                StartDate = new DateTime(2025, 3, 12),
                EndDate = new DateTime(2025, 3, 18),
                CarId = CarTwo.Id,
                CustomerId = Customer.Id,
                Total = 720,
                Status = "изчакваща"
            };

            RentThree = new Rent()
            {
                Id = 3,
                StartDate = new DateTime(2025, 4, 1),
                EndDate = new DateTime(2025, 4, 7),
                CarId = CarThree.Id,
                CustomerId = Customer.Id,
                Total = 480,
                Status = "отменена"
            };
        }
    }
}
