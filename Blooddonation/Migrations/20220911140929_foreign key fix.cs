using Microsoft.EntityFrameworkCore.Migrations;

namespace Blooddonation.Migrations
{
    public partial class foreignkeyfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Donor_Donor_DonorId1",
                table: "Donor");

            migrationBuilder.DropIndex(
                name: "IX_Donor_DonorId1",
                table: "Donor");

            migrationBuilder.DropColumn(
                name: "DonorId1",
                table: "Donor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DonorId1",
                table: "Donor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Donor_DonorId1",
                table: "Donor",
                column: "DonorId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Donor_Donor_DonorId1",
                table: "Donor",
                column: "DonorId1",
                principalTable: "Donor",
                principalColumn: "DonorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
