using CarsShowroom.Infrastructure.Data.Models;
using CarsShowroom.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarsShowroom.Infrastructure.Data
{
    public class CarsShowroomDbContext : IdentityDbContext
    {
        public CarsShowroomDbContext(DbContextOptions<CarsShowroomDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicles { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Manufacturer> Manufacturers { get; set; } = null!;
        public DbSet<Sale> Sales { get; set; } = null!;
        public DbSet<TestDrive> TestDrives { get; set; } = null!;
        public DbSet<Appointment> Appointments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TestDrive>()
                .HasOne(c => c.Customer)
                .WithMany(t => t.TestDrives)
                .HasForeignKey(t => t.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<TestDrive>()
                .HasOne(a => a.Appointment)
                .WithMany()
                .HasForeignKey(a => a.AppointmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Vehicle>()
                .HasOne(c => c.Customer)
                .WithMany(v => v.Vehicles)
                .HasForeignKey(v => v.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new CustomerConfiguration());
            builder.ApplyConfiguration(new ManufacturerConfiguration());
            builder.ApplyConfiguration(new VehicleConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
