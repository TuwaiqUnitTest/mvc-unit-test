using Microsoft.EntityFrameworkCore.Migrations;

namespace Event_Hall.Migrations
{
    public partial class addedEventRow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "Duration", "HallId", "Image", "Name", "PresentorId", "Time" },
                values: new object[] { 1, "To lose our jobs to our future supreme AI overlords ... or to not? That's the question (and we have some surprising answers).", "2 Hours", 3, "https://pi.tedcdn.com/r/talkstar-assets.s3.amazonaws.com/production/playlists/playlist_642/2437dd5f-4efd-40e9-a417-8c9d879ac9ea/What-happens-after-robots-take-our-jobs_1200x627+(1).jpg?quality=89&w=1200", "What happens when the robots take our jobs?", 10, "Friday, June 4, 2021 8:30:00 PM" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Attendees",
                columns: new[] { "Id", "Email", "EventId", "Field", "Name", "Phone" },
                values: new object[,]
                {
                    { 10, "spurofthemoment@gmail.com", 1, "IT", "Sameera Alhussainy", 556110112 },
                    { 12, "raneeeen@gmail.com", 1, "IT", "Raneen Alzafrani", 532120193 },
                    { 77, "toto@gmail.com", 1, "IT", "Batool Alghamdi", 554777892 },
                    { 13, "reema@gmail.com", 1, "IT", "Reema Alyousef", 547722199 }
                });
        }
    }
}
