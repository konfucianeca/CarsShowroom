using System.ComponentModel.DataAnnotations;

namespace CarsShowroom.Core.Models.Vehicle
{
    public class VehicleDeleteViewModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;

        [Display(Name ="Manufactured: ")]
        public string YearOfProduction { get; set; } = string.Empty;
    }
}
