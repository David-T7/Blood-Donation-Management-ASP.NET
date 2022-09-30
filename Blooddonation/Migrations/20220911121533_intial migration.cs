using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blooddonation.Migrations
{
    public partial class intialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "Donor",
                columns: table => new
                {
                    DonorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    BMI = table.Column<float>(type: "real", nullable: false),
                    DonorId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donor", x => x.DonorId);
                    table.ForeignKey(
                        name: "FK_Donor_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donor_Donor_DonorId1",
                        column: x => x.DonorId1,
                        principalTable: "Donor",
                        principalColumn: "DonorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    AccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonorId = table.Column<int>(type: "int", nullable: false),
                    AppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.AccountId);
                    table.ForeignKey(
                        name: "FK_Appointment_Donor_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donor",
                        principalColumn: "DonorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blood",
                columns: table => new
                {
                    BloodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonorId = table.Column<int>(type: "int", nullable: false),
                    BloodGroup = table.Column<int>(type: "int", nullable: false),
                    PackNumber = table.Column<int>(type: "int", nullable: false),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuantityOfBlood = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blood", x => x.BloodId);
                    table.ForeignKey(
                        name: "FK_Blood_Donor_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donor",
                        principalColumn: "DonorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonationReqeustResult",
                columns: table => new
                {
                    ReqeustResultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonorId = table.Column<int>(type: "int", nullable: false),
                    HeartDisease = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kidney_Lung_Bloodpressure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Liverproblems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tattoo_Ear_skin_pierced = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slpet_Unsafely_OtherThanPartner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeriousSkinRepair = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preagnant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abortion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BreastFeeding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BloodHealthfulnessInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationReqeustResult", x => x.ReqeustResultId);
                    table.ForeignKey(
                        name: "FK_DonationReqeustResult_Donor_DonorId",
                        column: x => x.DonorId,
                        principalTable: "Donor",
                        principalColumn: "DonorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_DonorId",
                table: "Appointment",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Blood_DonorId",
                table: "Blood",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationReqeustResult_DonorId",
                table: "DonationReqeustResult",
                column: "DonorId");

            migrationBuilder.CreateIndex(
                name: "IX_Donor_AccountId",
                table: "Donor",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Donor_DonorId1",
                table: "Donor",
                column: "DonorId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Blood");

            migrationBuilder.DropTable(
                name: "DonationReqeustResult");

            migrationBuilder.DropTable(
                name: "Donor");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
