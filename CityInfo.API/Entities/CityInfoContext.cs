using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.Entities
{
    public class CityInfoContext : DbContext
    {
        public CityInfoContext(DbContextOptions<CityInfoContext> options) 
            : base(options)
        {
            
        }

        public DbSet<City> City { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

    }
}