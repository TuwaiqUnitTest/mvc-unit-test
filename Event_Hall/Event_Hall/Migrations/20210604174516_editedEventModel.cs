using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Event_Hall.Migrations
{
    public partial class editedEventModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Time",
                table: "Events",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Time",
                table: "Events",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
