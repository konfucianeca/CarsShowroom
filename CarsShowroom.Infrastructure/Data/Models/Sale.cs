using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CarsShowroom.Infrastructure.Data.Models
{
    [Comment("Customer sales")]
    public class Sale
    {
        [Key]
        [Comment("Sale identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Date sale took place")]
        public DateTime SaleDate { get; set; }

        [Required]
        [ForeignKey(nameof(Vehicle))]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
