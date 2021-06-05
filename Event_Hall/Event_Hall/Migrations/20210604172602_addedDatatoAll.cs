using Microsoft.EntityFrameworkCore.Migrations;

namespace Event_Hall.Migrations
{
    public partial class addedDatatoAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 666,
                column: "EventId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Attendees",
                columns: new[] { "Id", "Email", "EventId", "Field", "Name", "Phone" },
                values: new object[,]
                {
                    { 13, "reema@gmail.com", 1, "IT", "Reema Alyousef", 547722199 },
                    { 7, "hala@gmail.com", 2, "Business", "Hala Alyousef", 554124771 },
                    { 4, "durrdurr@gmail.com", 2, "Marketing", "Dorrah Alsaad", 532121731 },
                    { 77, "toto@gmail.com", 1, "IT", "Batool Alghamdi", 554777892 },
                    { 12, "raneeeen@gmail.com", 1, "IT", "Raneen Alzafrani", 532120193 },
                    { 10, "spurofthemoment@gmail.com", 1, "IT", "Sameera Alhussainy", 556110112 },
                    { 407, "noura407@gmail.com", 3, "Health", "Noura Aldossary", 533172134 },
                    { 1, "njxx@gmail.com", 3, "Health", "Nujood Alyousef", 547712397 },
                    { 2, "lia@gmail.com", 3, "Health", "Lama Alyousef", 551212432 }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Avaliability", "Capacity", "Name" },
                values: new object[,]
                {
                    { 1, true, 50, "First Venue" },
                    { 2, false, 200, "Main Hall" },
                    { 3, true, 1000, "Conference Hall " }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 666,
                column: "EventId",
                value: 4);
        }
    }
}
