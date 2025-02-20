using CarsShowroom.Core.Models.Home;

namespace CarsShowroom.Core.Models.Vehicle
{
    public class VehicleDetailsViewModel : VehicleIndexServiceModel
    {
        public string Region { get; set; } = string.Empty;
        public string Gearbox { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string? Condition { get; set; } 
        public int Mileage { get; set; }
        public string Features { get; set; } = string.Empty;
        public int ManufacturerId { get; set; }
        public int Displacement { get; set; } 
        public int Power { get; set; } 
        public string Customer { get; set; } = null!;
    }
}
