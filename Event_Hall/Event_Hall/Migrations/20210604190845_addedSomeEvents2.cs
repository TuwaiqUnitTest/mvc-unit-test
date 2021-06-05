using Microsoft.EntityFrameworkCore.Migrations;

namespace Event_Hall.Migrations
{
    public partial class addedSomeEvents2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "Duration", "HallId", "Image", "Name", "PresentorId", "Time" },
                values: new object[,]
                {
                    { 1000, "To lose our jobs to our future supreme AI overlords ... or to not? That's the question (and we have some surprising answers).", "2 Hours", 3, "https://pi.tedcdn.com/r/talkstar-assets.s3.amazonaws.com/production/playlists/playlist_642/2437dd5f-4efd-40e9-a417-8c9d879ac9ea/What-happens-after-robots-take-our-jobs_1200x627+(1).jpg?quality=89&w=1200", "What happens when the robots take our jobs?", 10, "Friday, June 4, 2021 8:30:00 PM" },
                    { 9999, "In 2014, the world avoided a global outbreak of Ebola, thanks to thousands of selfless health workers -- plus, frankly, some very good luck. In hindsight, we know what we should have done better. So, now's the time, MJ suggests, to put all our good ideas into practice, from scenario planning to vaccine research to health worker training. As he says, There's no need to panic ... but we need to get going.", "3 Hours", 2, "https://www.gard.no/Content/29112072/cache=20203101143212/Coronavirus_people.jpg", "The Next Outbreak? We're Not Ready", 665, "Friday, August 1, 2021 7:30:00 PM" },
                    { 111111, "Reema Alyousef knows that procrastination doesn't make sense, but she's never been able to shake her habit of waiting until the last minute to get things done. In this hilarious and insightful talk, Reema takes us on a journey through YouTube binges, Gaming rabbit holes and bouts of staring out the window -- and encourages us to think harder about what we're really procrastinating on, before we run out of time.", "3 Hours", 1, "https://cdn.substack.com/image/fetch/f_auto,q_auto:good,fl_progressive:steep/https%3A%2F%2Fbucketeer-e05bbc84-baa3-437e-9518-adb32be77984.s3.amazonaws.com%2Fpublic%2Fimages%2F3586ad3c-6847-457a-ba75-b3f5d4e6d46a_1920x1080.png", "Inside the Mind of a Master Procrastinator", 13, "Friday, August 16, 2021 6:30:00 PM" }
                });

            migrationBuilder.UpdateData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Field", "Name", "Phone" },
                values: new object[] { "hanan@gmail.com", "Gaming", "Hanan Alhakami", 598644222 });

            migrationBuilder.InsertData(
                table: "Presentors",
                columns: new[] { "Id", "Email", "Field", "Name", "Phone" },
                values: new object[,]
                {
                    { 100, "hala@galaxybrain.com", "Bullshit", "Hala Alyousef", 522441234 },
                    { 333, "reema@galaxybrain.com", "Divine Philosophy", "Reema Alyousef", 547722199 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 9999);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 111111);

            migrationBuilder.DeleteData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "Duration", "HallId", "Image", "Name", "PresentorId", "Time" },
                values: new object[] { 1, "To lose our jobs to our future supreme AI overlords ... or to not? That's the question (and we have some surprising answers).", "2 Hours", 3, "https://pi.tedcdn.com/r/talkstar-assets.s3.amazonaws.com/production/playlists/playlist_642/2437dd5f-4efd-40e9-a417-8c9d879ac9ea/What-happens-after-robots-take-our-jobs_1200x627+(1).jpg?quality=89&w=1200", "What happens when the robots take our jobs?", 10, "Friday, June 4, 2021 8:30:00 PM" });

            migrationBuilder.UpdateData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "Field", "Name", "Phone" },
                values: new object[] { "stephen@galaxybrain.com", "Science", "Stephen Hawking", 522443298 });
        }
    }
}
