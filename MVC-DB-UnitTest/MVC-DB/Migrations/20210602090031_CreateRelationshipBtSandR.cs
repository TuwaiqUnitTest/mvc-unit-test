using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DB.Migrations
{
    public partial class CreateRelationshipBtSandR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudnetId",
                table: "Rooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_StudnetId",
                table: "Rooms",
                column: "StudnetId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Studnets_StudnetId",
                table: "Rooms",
                column: "StudnetId",
                principalTable: "Studnets",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Studnets_StudnetId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_StudnetId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "StudnetId",
                table: "Rooms");
        }
    }
}
