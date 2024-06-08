using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Project.Migrations
{
    public partial class Propertyissoftdeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Informations_Abouts_AboutId",
                table: "Informations");

            migrationBuilder.DropIndex(
                name: "IX_Informations_AboutId",
                table: "Informations");

            migrationBuilder.DropColumn(
                name: "AboutId",
                table: "Informations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AboutId",
                table: "Informations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Informations_AboutId",
                table: "Informations",
                column: "AboutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Informations_Abouts_AboutId",
                table: "Informations",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
