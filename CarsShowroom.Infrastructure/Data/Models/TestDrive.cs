using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static CarsShowroom.Infrastructure.Constants.DataConstants;

namespace CarsShowroom.Infrastructure.Data.Models
{
    [Comment("Customer test drive for particular vehicle")]
    public class TestDrive
    {
        [Key]
        [Comment("Test drive identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Time test drive starts")]
        public DateTime TestStart { get; set; }

        [Required]
        [Comment("Time test drive ends")]
        public DateTime TestEnd { get; set; }

        [MaxLength(TestNotesMaxLenght)]
        [Comment("Notes over test drive results")]
        public string TestNotes { get; set; } = string.Empty;

        [Required]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Appointment))]
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; } = null!;

        //[ForeignKey(nameof(Vehicle))]
        //[Comment("Vehicle identifier")]
        //public int VehicleId { get; set; }
        //public Vehicle Vehicle { get; set; } = null!;
    }
}
