using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace MVC_DB.Migrations
{
    public partial class CreateTeachers1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fullName = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");

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
    }
}
