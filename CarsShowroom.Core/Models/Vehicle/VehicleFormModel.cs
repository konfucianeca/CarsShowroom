using CarsShowroom.Core.Models.Engine;
using CarsShowroom.Core.Models.Manufacturer;
using CarsShowroom.Infrastructure.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using static CarsShowroom.Core.Constants.MessageConstants;
using static CarsShowroom.Infrastructure.Constants.DataConstants;

namespace CarsShowroom.Core.Models.Vehicle
{
    public class VehicleFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(VehicleModelMaxLenght,
            MinimumLength = VehicleModelMinLenght,
            ErrorMessage = StringLengthMessage)]
        public string Model { get; set; } = null!;
        public Condition? Condition { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [MaxLength(4)]
        public string YearOfProduction { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(RegionNameMaxLenght,
            MinimumLength = RegionNameMinLenght,
            ErrorMessage = StringLengthMessage)]
        public string Region { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        public Gearbox Gearbox { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ColorNameMaxLenght,
            MinimumLength = ColorNameMinLenght,
            ErrorMessage = StringLengthMessage)]
        public string Color { get; set; } = null!;

        public int Mileage { get; set; }

        [StringLength(VehicleFeaturesMaxLenght,
            MinimumLength = VehicleFeaturesMinLenght,
            ErrorMessage = StringLengthMessage)]
        public string Features { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        public decimal Price { get; set; }

        [MaxLength(VehicleImageUrlMaxLenght)]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        public int ManufacturerId { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        public int EngineId { get; set; }

        public IEnumerable<ManufacturerServiceModel> Manufacturers { get; set; } = new List<ManufacturerServiceModel>();
        public IEnumerable<VehicleEngineServiceModel> Engines { get; set; } = new List<VehicleEngineServiceModel>();
    }
}
