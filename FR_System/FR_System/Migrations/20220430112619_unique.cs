using Microsoft.EntityFrameworkCore.Migrations;

namespace FR_System.Migrations
{
    public partial class unique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "TblUser",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_TblUser_UserName_Email",
                table: "TblUser",
                columns: new[] { "UserName", "Email" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TblUser_UserName_Email",
                table: "TblUser");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "TblUser",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
