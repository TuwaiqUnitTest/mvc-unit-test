using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DB.Migrations
{
    public partial class NewFieldToRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "roomNumber",
                table: "Rooms",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "roomNumber",
                table: "Rooms");
        }
    }
}
