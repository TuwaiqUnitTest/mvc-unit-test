using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DB.Migrations
{
    public partial class removeRoomType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "roomType",
                table: "Rooms");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "roomType",
                table: "Rooms",
                type: "text",
                nullable: true);
        }
    }
}
