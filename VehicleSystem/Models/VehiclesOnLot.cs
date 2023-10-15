using Microsoft.EntityFrameworkCore;

namespace VehicleSystem.Models
{
    public class VehiclesOnLot : DbContext
    {
        public VehiclesOnLot(DbContextOptions<VehiclesOnLot> options) : base(options)
        { }
        public DbSet<Vehicle> vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().HasData(
                // Current Vehicles on Lot
                new Vehicle
                {
                    VehicleId = 1,
                    Year = 1996,
                    Make = "Honda",
                    VehModel = "Civic",
                    Trim = "DX",
                    BodyStyle = "Hatchback"
                },
                new Vehicle
                {
                    VehicleId = 2,
                    Year = 1997,
                    Make = "Honda",
                    VehModel = "Civic",
                    Trim = "Si",
                    BodyStyle = "Coupe"

                }
            );
        }
    }
}
