using Microsoft.EntityFrameworkCore.Migrations;

namespace FR_System.Migrations
{
    public partial class booking1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Payment",
                table: "TblReservation",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Payment",
                table: "TblReservation");
        }
    }
}
