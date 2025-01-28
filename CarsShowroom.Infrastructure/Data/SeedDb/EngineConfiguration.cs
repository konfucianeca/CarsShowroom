using CarsShowroom.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarsShowroom.Infrastructure.Data.SeedDb
{
    internal class EngineConfiguration : IEntityTypeConfiguration<Engine>
    {
        public void Configure(EntityTypeBuilder<Engine> builder)
        {
            var data = new SeedData();

            builder.HasData(new Engine[] { data.FirstEngine, data.SecondEngine, data.ThirdEngine });
        }
    }
}
