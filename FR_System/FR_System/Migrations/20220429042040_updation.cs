using Microsoft.EntityFrameworkCore.Migrations;

namespace FR_System.Migrations
{
    public partial class updation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblFlight_TblPlane_PlaneId",
                table: "TblFlight");

            migrationBuilder.DropColumn(
                name: "NICNo",
                table: "TblUser");

            migrationBuilder.RenameColumn(
                name: "PlaneId",
                table: "TblFlight",
                newName: "PlaneID");

            migrationBuilder.RenameIndex(
                name: "IX_TblFlight_PlaneId",
                table: "TblFlight",
                newName: "IX_TblFlight_PlaneID");

            migrationBuilder.AddForeignKey(
                name: "FK_TblFlight_TblPlane_PlaneID",
                table: "TblFlight",
                column: "PlaneID",
                principalTable: "TblPlane",
                principalColumn: "PlaneID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblFlight_TblPlane_PlaneID",
                table: "TblFlight");

            migrationBuilder.RenameColumn(
                name: "PlaneID",
                table: "TblFlight",
                newName: "PlaneId");

            migrationBuilder.RenameIndex(
                name: "IX_TblFlight_PlaneID",
                table: "TblFlight",
                newName: "IX_TblFlight_PlaneId");

            migrationBuilder.AddColumn<string>(
                name: "NICNo",
                table: "TblUser",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_TblFlight_TblPlane_PlaneId",
                table: "TblFlight",
                column: "PlaneId",
                principalTable: "TblPlane",
                principalColumn: "PlaneID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
