using CarsShowroom.Core.Models.Manufacturer;
using CarsShowroom.Infrastructure.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using static CarsShowroom.Core.Constants.MessageConstants;
using static CarsShowroom.Infrastructure.Constants.DataConstants;

namespace CarsShowroom.Core.Models.Vehicle
{
    public class VehicleServiceModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(VehicleModelMaxLenght,
            MinimumLength = VehicleModelMinLenght,
            ErrorMessage = StringLengthMessage)]
        public string Model { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ColorNameMaxLenght,
            MinimumLength = ColorNameMinLenght,
            ErrorMessage = StringLengthMessage)]
        public string Color { get; set; } = null!;

        public int Mileage { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        public decimal Price { get; set; }

        [MaxLength(VehicleImageUrlMaxLenght)]
        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        public int ManufacturerId { get; set; }
        public string SellerId { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        public Engine EngineType { get; set; }

        [Display(Name = "Sold!")]
        public bool IsSold { get; set; }

        public IEnumerable<ManufacturerServiceModel> Manufacturers { get; set; } = new List<ManufacturerServiceModel>();
    }
}
