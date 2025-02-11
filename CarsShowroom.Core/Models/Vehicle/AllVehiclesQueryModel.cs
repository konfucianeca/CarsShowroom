using CarsShowroom.Core.Models.Home;

namespace CarsShowroom.Core.Models.Vehicle
{
    public class AllVehiclesQueryModel : VehicleIndexServiceModel
    {
        public string Region { get; set; } = string.Empty;
        public int Mileage { get; set; } 
    }
}
