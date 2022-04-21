using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FR_System.Migrations
{
    public partial class initialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblAdmin",
                columns: table => new
                {
                    AdminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminName = table.Column<string>(maxLength: 20, nullable: false),
                    Password = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAdmin", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "TblPlane",
                columns: table => new
                {
                    PlaneID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaneName = table.Column<string>(maxLength: 20, nullable: false),
                    Seats = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblPlane", x => x.PlaneID);
                });

            migrationBuilder.CreateTable(
                name: "TblUser",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Phoneno = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUser", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "TblFlight",
                columns: table => new
                {
                    FlightId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightFrom = table.Column<string>(nullable: false),
                    FlightTo = table.Column<string>(nullable: false),
                    FlightDDate = table.Column<DateTime>(nullable: false),
                    DTime = table.Column<string>(maxLength: 15, nullable: false),
                    PlaneId = table.Column<int>(nullable: false),
                    price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFlight", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_TblFlight_TblPlane_PlaneId",
                        column: x => x.PlaneId,
                        principalTable: "TblPlane",
                        principalColumn: "PlaneID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblReservation",
                columns: table => new
                {
                    ReservationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblReservation", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_TblReservation_TblFlight_FlightId",
                        column: x => x.FlightId,
                        principalTable: "TblFlight",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblFlight_PlaneId",
                table: "TblFlight",
                column: "PlaneId");

            migrationBuilder.CreateIndex(
                name: "IX_TblReservation_FlightId",
                table: "TblReservation",
                column: "FlightId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblAdmin");

            migrationBuilder.DropTable(
                name: "TblReservation");

            migrationBuilder.DropTable(
                name: "TblUser");

            migrationBuilder.DropTable(
                name: "TblFlight");

            migrationBuilder.DropTable(
                name: "TblPlane");
        }
    }
}
