using CarsShowroom.Infrastructure.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static CarsShowroom.Infrastructure.Constants.DataConstants;

namespace CarsShowroom.Infrastructure.Data.Models
{
    [Comment("Vehicle to sale")]
    public class Vehicle
    {
        public Vehicle()
        {
            this.Appointments = new List<Appointment>();
            this.TestDrives = new List<TestDrive>();
            this.Sales = new List<Sale>();
        }

        [Key]
        [Comment("Vehicle identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(VehicleModelMaxLenght)]
        [Comment("Vehicle model")]
        public string Model { get; set; } = string.Empty;
        public Condition? Condition { get; set; }

        [Required]
        [Comment("Vehicle production year")]
        public string YearOfProduction { get; set; }

        [Required]
        [MaxLength(RegionNameMaxLenght)]
        [Comment("Settlement where vehicle is")]
        public string Region { get; set; } = string.Empty;

        [Required]
        [Comment("What type gearbox fitted on the vehicle")]
        public Gearbox Gearbox { get; set; }

        [Required]
        [MaxLength(ColorNameMaxLenght)]
        [Comment("Vehicle color")]
        public string Color { get; set; } = string.Empty;

        [Comment("Total distance driven by car up to now")]
        public int Mileage { get; set; }

        [MaxLength(VehicleFeaturesMaxLenght)]
        [Comment("Vehicle additional equipment")]
        public string Features { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Comment("Car price")]
        public decimal Price { get; set; }

        [MaxLength(VehicleImageUrlMaxLenght)]
        [Comment("Vehicle image")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Comment("Manufacturer identifier")]
        public int ManufacturerId { get; set; }

        [ForeignKey(nameof(ManufacturerId))]
        public Manufacturer Manufacturer { get; set; } = null!;

        [Required]
        [Comment("Vehicle engine type")]
        public Engine EngineType { get; set; }
        public int Displacement { get; set; }
        public int Power { get; set; }

        [Required]
        [Comment("Customer identifier")]
        public int CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; } = null!;
        public IEnumerable<Appointment> Appointments { get; set; }
        public IEnumerable<TestDrive> TestDrives { get; set; }
        public IEnumerable<Sale> Sales { get; set; }
    }
}
