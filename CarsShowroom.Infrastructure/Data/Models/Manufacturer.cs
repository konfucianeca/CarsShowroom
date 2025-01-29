using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static CarsShowroom.Infrastructure.Constants.DataConstants;

namespace CarsShowroom.Infrastructure.Data.Models
{
    [Comment("Vehicle producer")]
    public class Manufacturer
    {
        public Manufacturer()
        {
            this.Vehicles = new List<Vehicle>();
        }

        [Key]
        [Comment("Manufacturer identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ManufacturerNameMaxLenght)]
        [Comment("Vehicle manufacturer name")]
        public string Name { get; set; } = string.Empty;
        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}
