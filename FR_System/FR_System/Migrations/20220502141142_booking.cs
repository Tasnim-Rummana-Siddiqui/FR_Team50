using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FR_System.Migrations
{
    public partial class booking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblReservation_TblPlane_PlaneId",
                table: "TblReservation");

            migrationBuilder.DropIndex(
                name: "IX_TblReservation_PlaneId",
                table: "TblReservation");

            migrationBuilder.DropColumn(
                name: "DTime",
                table: "TblReservation");

            migrationBuilder.DropColumn(
                name: "FlightDDate",
                table: "TblReservation");

            migrationBuilder.DropColumn(
                name: "FlightFrom",
                table: "TblReservation");

            migrationBuilder.DropColumn(
                name: "FlightTo",
                table: "TblReservation");

            migrationBuilder.DropColumn(
                name: "PlaneId",
                table: "TblReservation");

            migrationBuilder.DropColumn(
                name: "price",
                table: "TblReservation");

            migrationBuilder.AddColumn<decimal>(
                name: "Totalprice",
                table: "TblReservation",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "Travellers",
                table: "TblReservation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "TblReservation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TblReservation_UserId",
                table: "TblReservation",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblReservation_TblUser_UserId",
                table: "TblReservation",
                column: "UserId",
                principalTable: "TblUser",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblReservation_TblUser_UserId",
                table: "TblReservation");

            migrationBuilder.DropIndex(
                name: "IX_TblReservation_UserId",
                table: "TblReservation");

            migrationBuilder.DropColumn(
                name: "Totalprice",
                table: "TblReservation");

            migrationBuilder.DropColumn(
                name: "Travellers",
                table: "TblReservation");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TblReservation");

            migrationBuilder.AddColumn<string>(
                name: "DTime",
                table: "TblReservation",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FlightDDate",
                table: "TblReservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FlightFrom",
                table: "TblReservation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FlightTo",
                table: "TblReservation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PlaneId",
                table: "TblReservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "TblReservation",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_TblReservation_PlaneId",
                table: "TblReservation",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblReservation_TblPlane_PlaneId",
                table: "TblReservation",
                column: "PlaneId",
                principalTable: "TblPlane",
                principalColumn: "PlaneID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
