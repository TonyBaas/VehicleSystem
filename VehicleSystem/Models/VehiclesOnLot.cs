using Microsoft.EntityFrameworkCore;

namespace VehicleSystem.Models
{
    public class VehiclesOnLot : DbContext
    {
        public VehiclesOnLot(DbContextOptions<VehiclesOnLot> options) : base(options)
        { }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(
                // Current Vehicles on Lot
                new Vehicle
                {
                    VehicleId = 1,
                    Year = 1996,
                    Make = "Honda",
                    Model = "Civic",
                    Trim = "DX"
                },
                new Vehicle
                {
                    VehicleId = 2,
                    Year = 1997,
                    Make = "Honda",
                    Model = "Civic",
                    Trim = "DX"
                }
            );
        }
    }
}
