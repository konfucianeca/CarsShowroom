using CarsShowroom.Infrastructure.Data.Models.Enums;

namespace CarsShowroom.Core.Models.Vehicle
{
    public class VehicleDetailsViewModel
    {
        public int Id { get; set; }
        public string Model { get; set; } = string.Empty;
        public Condition? Condition { get; set; }
        public string YearOfProduction { get; set; } = null!;
        public string Region { get; set; } = string.Empty;
        public Gearbox Gearbox { get; set; }
        public string Color { get; set; } = string.Empty;
        public int Mileage { get; set; }
        public string Features { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public int ManufacturerId { get; set; }
        public Engine EngineType { get; set; }
        public int Displacement { get; set; }
        public int Power { get; set; }
    }
}
