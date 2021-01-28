using Microsoft.EntityFrameworkCore.Migrations;

namespace YSKProje.ToDo.DataAccess.Migrations
{
    public partial class AppUserGorevEROnetoMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Calismalar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Calismalar_AppUserId",
                table: "Calismalar",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calismalar_AspNetUsers_AppUserId",
                table: "Calismalar",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calismalar_AspNetUsers_AppUserId",
                table: "Calismalar");

            migrationBuilder.DropIndex(
                name: "IX_Calismalar_AppUserId",
                table: "Calismalar");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Calismalar");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");
        }
    }
}
