using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FR_System.Migrations
{
    public partial class newmigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phoneno",
                table: "TblUser",
                newName: "PhoneNo");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "TblFlight",
                newName: "Price");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNo",
                table: "TblUser",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "TblUser",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "TblUser",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "TblUser",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "TblUser",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "TblUser",
                maxLength: 40,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CPassword",
                table: "TblUser",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "TblUser",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NICNo",
                table: "TblUser",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "TblUser",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DTime",
                table: "TblReservation",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FlightDDate",
                table: "TblReservation",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FlightFrom",
                table: "TblReservation",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FlightTo",
                table: "TblReservation",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PlaneId",
                table: "TblReservation",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "TblReservation",
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
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblReservation_TblPlane_PlaneId",
                table: "TblReservation");

            migrationBuilder.DropIndex(
                name: "IX_TblReservation_PlaneId",
                table: "TblReservation");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "TblUser");

            migrationBuilder.DropColumn(
                name: "CPassword",
                table: "TblUser");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "TblUser");

            migrationBuilder.DropColumn(
                name: "NICNo",
                table: "TblUser");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "TblUser");

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

            migrationBuilder.RenameColumn(
                name: "PhoneNo",
                table: "TblUser",
                newName: "Phoneno");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "TblFlight",
                newName: "price");

            migrationBuilder.AlterColumn<string>(
                name: "Phoneno",
                table: "TblUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "TblUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "TblUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "TblUser",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "TblUser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
