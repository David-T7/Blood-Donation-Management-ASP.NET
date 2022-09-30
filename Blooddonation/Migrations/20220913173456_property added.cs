using Microsoft.EntityFrameworkCore.Migrations;

namespace Blooddonation.Migrations
{
    public partial class propertyadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DonationReqeustResultReqeustResultId",
                table: "Appointment",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReqeustResultId",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_DonationReqeustResultReqeustResultId",
                table: "Appointment",
                column: "DonationReqeustResultReqeustResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_DonationReqeustResult_DonationReqeustResultReqeustResultId",
                table: "Appointment",
                column: "DonationReqeustResultReqeustResultId",
                principalTable: "DonationReqeustResult",
                principalColumn: "ReqeustResultId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_DonationReqeustResult_DonationReqeustResultReqeustResultId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_DonationReqeustResultReqeustResultId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "DonationReqeustResultReqeustResultId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "ReqeustResultId",
                table: "Appointment");
        }
    }
}
