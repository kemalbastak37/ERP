using Microsoft.EntityFrameworkCore.Migrations;

namespace YSKProje.ToDo.DataAccess.Migrations
{
    public partial class CreateTableAciliyet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calismalar_AspNetUsers_AppUserId",
                table: "Calismalar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Calismalar",
                table: "Calismalar");

            migrationBuilder.RenameTable(
                name: "Calismalar",
                newName: "Gorevler");

            migrationBuilder.RenameIndex(
                name: "IX_Calismalar_AppUserId",
                table: "Gorevler",
                newName: "IX_Gorevler_AppUserId");

            migrationBuilder.AddColumn<int>(
                name: "AciliyetId",
                table: "Gorevler",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gorevler",
                table: "Gorevler",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Aciliyetler",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aciliyetler", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gorevler_AciliyetId",
                table: "Gorevler",
                column: "AciliyetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevler_Aciliyetler_AciliyetId",
                table: "Gorevler",
                column: "AciliyetId",
                principalTable: "Aciliyetler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevler_AspNetUsers_AppUserId",
                table: "Gorevler",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gorevler_Aciliyetler_AciliyetId",
                table: "Gorevler");

            migrationBuilder.DropForeignKey(
                name: "FK_Gorevler_AspNetUsers_AppUserId",
                table: "Gorevler");

            migrationBuilder.DropTable(
                name: "Aciliyetler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gorevler",
                table: "Gorevler");

            migrationBuilder.DropIndex(
                name: "IX_Gorevler_AciliyetId",
                table: "Gorevler");

            migrationBuilder.DropColumn(
                name: "AciliyetId",
                table: "Gorevler");

            migrationBuilder.RenameTable(
                name: "Gorevler",
                newName: "Calismalar");

            migrationBuilder.RenameIndex(
                name: "IX_Gorevler_AppUserId",
                table: "Calismalar",
                newName: "IX_Calismalar_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calismalar",
                table: "Calismalar",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Calismalar_AspNetUsers_AppUserId",
                table: "Calismalar",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
