using Microsoft.EntityFrameworkCore.Migrations;

namespace Blooddonation.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Appointment",
                newName: "AppointmentId");

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Donor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Height",
                table: "Donor",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<long>(
                name: "PhoneNo",
                table: "Donor",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Account",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Donor");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Donor");

            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "Donor");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Account");

            migrationBuilder.RenameColumn(
                name: "AppointmentId",
                table: "Appointment",
                newName: "AccountId");
        }
    }
}
