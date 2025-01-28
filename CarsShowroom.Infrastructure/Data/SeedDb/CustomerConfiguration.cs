using CarsShowroom.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarsShowroom.Infrastructure.Data.SeedDb
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            var data = new SeedData();

            builder.HasData(new Customer[] { data.FirstCustomer });
        }
    }
}
