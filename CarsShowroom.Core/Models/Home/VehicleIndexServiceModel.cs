namespace CarsShowroom.Core.Models.Home
{
    public class VehicleIndexServiceModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Maker { get; set; }
        public string Model { get; set; } = string.Empty;
        public string YearOfProduction { get; set; } = string.Empty;
        public string EngineType { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
