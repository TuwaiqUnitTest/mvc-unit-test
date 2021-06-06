using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class AddRelationShipsRoomToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "Rooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_StudentID",
                table: "Rooms",
                column: "StudentID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Students_StudentID",
                table: "Rooms",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Students_StudentID",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_StudentID",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "Rooms");
        }
    }
}
