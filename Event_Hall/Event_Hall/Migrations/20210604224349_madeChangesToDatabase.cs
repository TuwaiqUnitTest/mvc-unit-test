using Microsoft.EntityFrameworkCore.Migrations;

namespace Event_Hall.Migrations
{
    public partial class madeChangesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12223,
                column: "Description",
                value: "Hala Alyousef admits she won a genetic lottery: she's tall, pretty and a high fashion model. But don't judge her by her looks. In this fearless talk, she takes a wry look at the industry that had her looking highly seductive at barely 16 years old.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12223,
                column: "Description",
                value: "Hala Alyousef admits she won a genetic lottery: she's tall, pretty and an underwear model. But don't judge her by her looks. In this fearless talk, she takes a wry look at the industry that had her looking highly seductive at barely 16 years old.");
        }
    }
}
