using Microsoft.EntityFrameworkCore.Migrations;

namespace Event_Hall.Migrations
{
    public partial class addedDatatoPresentors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "EventId", "Field" },
                values: new object[] { 4, "Biology" });

            migrationBuilder.InsertData(
                table: "Presentors",
                columns: new[] { "Id", "Email", "Field", "Name", "Phone" },
                values: new object[,]
                {
                    { 10, "spurofthemoment@gmail.com", "IT", "Sameera Alhussainy", 556110112 },
                    { 2, "ceo@tesla.com", "Business", "Elon Musk", 556123123 },
                    { 665, "mj@gmail.com", "Health", "Michael Jackson", 522666987 },
                    { 1, "stephen@galaxybrain.com", "Science", "Stephen Hawking", 522443298 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "EventId", "Field" },
                values: new object[] { 2, "Business" });

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
        }
    }
}
