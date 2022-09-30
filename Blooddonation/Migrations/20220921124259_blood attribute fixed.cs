using Microsoft.EntityFrameworkCore.Migrations;

namespace Blooddonation.Migrations
{
    public partial class bloodattributefixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BloodGroup",
                table: "Blood");

            migrationBuilder.AddColumn<string>(
                name: "BloodType",
                table: "Blood",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BloodType",
                table: "Blood");

            migrationBuilder.AddColumn<int>(
                name: "BloodGroup",
                table: "Blood",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
