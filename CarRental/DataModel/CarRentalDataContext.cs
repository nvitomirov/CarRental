using Microsoft.EntityFrameworkCore;


namespace CarRental.DataModel
{
    public class CarRentalDataContext : DbContext
    {

        public CarRentalDataContext(DbContextOptions<CarRentalDataContext> options)
  : base(options)
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Vehicle>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }

    }
}
