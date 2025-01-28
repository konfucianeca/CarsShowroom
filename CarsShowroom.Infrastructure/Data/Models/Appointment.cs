using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CarsShowroom.Infrastructure.Constants.DataConstants;

namespace CarsShowroom.Infrastructure.Data.Models
{
    [Comment("Appointment for test drive or inspection")]
    public class Appointment
    {
        [Key]
        [Comment("Appointment identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(AppointmentDateMaxLenght)]
        [Comment("Date of appointment")]
        public DateTime AppointmentDate { get; set; }

        [Required]
        [ForeignKey(nameof(Vehicle))]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; } = null!;
    }
}
