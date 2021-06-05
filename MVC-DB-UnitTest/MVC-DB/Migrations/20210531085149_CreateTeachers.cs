using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DB.Migrations
{
    public partial class CreateTeachers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Studnets",
                table: "Studnets");

            migrationBuilder.RenameTable(
                name: "Studnets",
                newName: "StudnetModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudnetModel",
                table: "StudnetModel",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudnetModel",
                table: "StudnetModel");

            migrationBuilder.RenameTable(
                name: "StudnetModel",
                newName: "Studnets");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Studnets",
                table: "Studnets",
                column: "ID");
        }
    }
}
