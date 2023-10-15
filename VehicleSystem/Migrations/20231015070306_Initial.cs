using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleSystem.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Make = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyStyle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.VehicleId);
                });

            migrationBuilder.InsertData(
                table: "vehicles",
                columns: new[] { "VehicleId", "BodyStyle", "Make", "Trim", "VehModel", "Year" },
                values: new object[,]
                {
                    { 1, "Hatchback", "Honda", "DX", "Civic", 1996 },
                    { 2, "Coupe", "Honda", "Si", "Civic", 1997 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vehicles");
        }
    }
}
