using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DB.Migrations
{
    public partial class RemoveAvalibltyRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "avalibalty",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.InsertData(
                table: "Studnets",
                columns: new[] { "ID", "email", "firstName", "lastName" },
                values: new object[] { 1, "rawabe44u@gmail.com", "Rawabe", "Ebrahim" });

            migrationBuilder.InsertData(
                table: "Studnets",
                columns: new[] { "ID", "email", "firstName", "lastName" },
                values: new object[] { 2, "reema@gmail.com", "Reema", "Alyosif" });

            migrationBuilder.InsertData(
                table: "Studnets",
                columns: new[] { "ID", "email", "firstName", "lastName" },
                values: new object[] { 3, "amal@gmail.com", "Amal", "Alagel" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Studnets",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Studnets",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Studnets",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "avalibalty",
                table: "Rooms",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
