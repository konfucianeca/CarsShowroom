using CarsShowroom.Infrastructure.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CarsShowroom.Infrastructure.Data.Models
{
    [Comment("Vehicle engine")]
    public class Engine
    {
        public Engine()
        {
            this.Vehicles = new List<Vehicle>();
        }

        [Key]
        [Comment("Engine identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Vehicle engine type")]
        public EngineType EngineType { get; set; }
        public int Displacement { get; set; }
        public int Power { get; set; }
        public IEnumerable<Vehicle> Vehicles { get; set; }
    }
}
