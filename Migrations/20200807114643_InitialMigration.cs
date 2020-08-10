using Microsoft.EntityFrameworkCore.Migrations;

namespace Scott_Allen_Linq_Fundamentals.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Displacement = table.Column<double>(nullable: false),
                    Cylinders = table.Column<int>(nullable: false),
                    City = table.Column<int>(nullable: false),
                    Highway = table.Column<int>(nullable: false),
                    Combined = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
