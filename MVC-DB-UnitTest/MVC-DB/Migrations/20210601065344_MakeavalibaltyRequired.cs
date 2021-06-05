using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DB.Migrations
{
    public partial class MakeavalibaltyRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "avalibalty",
                table: "Rooms",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "avalibalty",
                table: "Rooms",
                type: "text",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
