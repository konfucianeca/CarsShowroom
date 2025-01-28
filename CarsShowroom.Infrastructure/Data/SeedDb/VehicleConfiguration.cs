using CarsShowroom.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarsShowroom.Infrastructure.Data.SeedDb
{
    internal class VehicleConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            var data = new SeedData();

            builder.HasData(new Vehicle[] { data.FirstVehicle, data.SecondVehicle, data.ThirdVehicle });
        }
    }
}
