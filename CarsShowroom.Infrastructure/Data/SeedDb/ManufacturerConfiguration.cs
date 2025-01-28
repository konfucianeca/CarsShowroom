using CarsShowroom.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarsShowroom.Infrastructure.Data.SeedDb
{
    internal class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            var data = new SeedData();

            builder.HasData(new Manufacturer[] { data.FirstManufacturer, data.SecondManufacturer, data.ThirdManufacturer });
        }
    }
}
