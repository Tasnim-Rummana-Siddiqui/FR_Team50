using Microsoft.EntityFrameworkCore.Migrations;

namespace FR_System.Migrations
{
    public partial class newmigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPassword",
                table: "TblUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPassword",
                table: "TblUser",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
