using System.ComponentModel.DataAnnotations;

namespace CarsShowroom.Core.Models.Home
{
    public class VehicleIndexServiceModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Maker { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string YearOfProduction { get; set; } = string.Empty;
        public string EngineType { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
