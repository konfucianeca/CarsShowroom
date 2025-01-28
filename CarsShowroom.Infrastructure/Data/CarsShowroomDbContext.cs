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
    }
}
