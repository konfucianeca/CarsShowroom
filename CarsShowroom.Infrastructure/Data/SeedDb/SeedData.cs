using CarsShowroom.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace CarsShowroom.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public IdentityUser User { get; set; }
        public Customer FirstCustomer { get; set; }
        public Vehicle FirstVehicle { get; set; }
        public Vehicle SecondVehicle { get; set; }
        public Vehicle ThirdVehicle { get; set; }
        public Manufacturer FirstManufacturer { get; set; }
        public Manufacturer SecondManufacturer { get; set; }
        public Manufacturer ThirdManufacturer { get; set; }

        public SeedData()
        {
            SeedManufacturers();
            SeedUsers();
            SeedCustomer();
            SeedVehicles();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            User = new IdentityUser()
            {
                Id = "302ded00ee6f4fea7f65fd9f66001b7f62f7673a02459f6930ba396bc26412de",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            User.PasswordHash = hasher.HashPassword(User, "guest123");
        }

        private void SeedCustomer()
        {
            FirstCustomer = new Customer()
            {
                Id = 1,
                Name = "Petar Petrov",
                DateOfBirth = DateTime.Parse("12/05/1985"),
                Address = "Varna, Pirin Str, 45",
                UserId = User.Id
            };
        }
        private void SeedVehicles()
        {
            FirstVehicle = new Vehicle()
            {
                Id = 1,
                ManufacturerId = FirstManufacturer.Id,
                Model = "X5 3.5i Xdrive",
                EngineType = Models.Enums.Engine.Petrol,
                Displacement = 3000,
                Power = 306,
                Condition = Models.Enums.Condition.GoodCondition,
                YearOfProduction = "2016",
                Region = "Plovdiv",
                Gearbox = Models.Enums.Gearbox.Automatic,
                Color = "Black",
                Mileage = 178000,
                Features = "4x4, ABS, ESP, Airbag, Халогенни фарове, ASR/Тракшън контрол, Парктроник, Аларма, Центр. заключване, Старт-Стоп система, Безключово палене",
                Price = 41500.00M,
                ImageUrl = "https://automoto.bg/listings/media/listing//1709991365_nis5vfph.jpg",
                CustomerId = FirstCustomer.Id
            };

            SecondVehicle = new Vehicle()
            {
                Id = 2,
                ManufacturerId = SecondManufacturer.Id,
                Model = "Santa Fe 2.2CRDI - 4WD",
                EngineType = Models.Enums.Engine.Petrol,
                Displacement = 2200,
                Power = 197,
                Condition = Models.Enums.Condition.GoodCondition,
                YearOfProduction = "2014",
                Region = "Lovech",
                Gearbox = Models.Enums.Gearbox.SemiAutomatic,
                Color = "Grey metalic",
                Mileage = 174000,
                Features = "4x4, ABS, ESP, Airbag, Ксенонови фарове, Халогенни фарове, ASR/Тракшън контрол, Парктроник, Аларма, Имобилайзер, Центр. заключване, Застраховка, Старт-Стоп система, Безключово палене",
                Price = 34000.00M,
                ImageUrl = "https://automoto.bg/listings/media/listing//1720295931_img-209442bc4babdf576e0cf1740ae33342-v.jpg",
                CustomerId = FirstCustomer.Id
            };

            ThirdVehicle = new Vehicle()
            {
                Id = 3,
                ManufacturerId = ThirdManufacturer.Id,
                Model = "Honda CR-V 2.2",
                EngineType = Models.Enums.Engine.Diesel,
                Displacement = 2200,
                Power = 150,
                Condition = Models.Enums.Condition.WithProblems,
                YearOfProduction = "2011",
                Region = "Smolyan",
                Gearbox = Models.Enums.Gearbox.Manual,
                Color = "Red",
                Mileage = 209000,
                Features = "  4x4, ABS, ESP, Airbag, Ксенонови фарове, Халогенни фарове, ASR/Тракшън контрол, Парктроник, Аларма, Имобилайзер, Центр. заключване, Застраховка",
                Price = 19000.00M,
                ImageUrl = "https://automoto.bg/listings/media/listing//1725859766_uml1.jpg",
                CustomerId = FirstCustomer.Id
            };
        }

        private void SeedManufacturers()
        {
            FirstManufacturer = new Manufacturer()
            {
                Id = 1,
                Name = "BMW"
            };

            SecondManufacturer = new Manufacturer()
            {
                Id = 2,
                Name = "Hyundai"
            };

            ThirdManufacturer = new Manufacturer()
            {
                Id = 3,
                Name = "Honda"
            };
        }
    }
}
