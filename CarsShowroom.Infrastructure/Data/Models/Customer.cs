using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static CarsShowroom.Infrastructure.Constants.DataConstants;

namespace CarsShowroom.Infrastructure.Data.Models
{
    [Comment("Cars showroom customer")]
    public class Customer
    {
        public Customer()
        {
            this.Vehicles = new List<Vehicle>();
            this.Appointments = new List<Appointment>();
            this.Sales = new List<Sale>();
            this.TestDrives = new List<TestDrive>();
        }

        [Key]
        [Comment("Customer identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(CustomerNameMaxLenght)]
        [Comment("Customer name")]
        public string Name { get; set; } = string.Empty;

        [MaxLength(CustomerBirthDateMaxLenght)]
        [Comment("Customer name")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(CustomerAddresslMaxLenght)]
        [Comment("Customer address")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public IEnumerable<Vehicle> Vehicles { get; set; }
        public IEnumerable<Appointment> Appointments { get; set; }
        public IEnumerable<Sale> Sales { get; set; }
        public IEnumerable<TestDrive> TestDrives { get; set; }
    }
}
