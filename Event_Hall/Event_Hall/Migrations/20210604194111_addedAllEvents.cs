using Microsoft.EntityFrameworkCore.Migrations;

namespace Event_Hall.Migrations
{
    public partial class addedAllEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 122222);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventId",
                value: 9999);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 2,
                column: "EventId",
                value: 9999);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 4,
                column: "EventId",
                value: 111111);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 7,
                column: "EventId",
                value: 111111);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 10,
                column: "EventId",
                value: 111111);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 12,
                column: "EventId",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 13,
                column: "EventId",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 77,
                column: "EventId",
                value: 1000);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 407,
                column: "EventId",
                value: 111111);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 666,
                column: "EventId",
                value: 111111);

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "Duration", "HallId", "Image", "Name", "PresentorId", "Time" },
                values: new object[,]
                {
                    { 12223, "Hala Alyousef admits she won a genetic lottery: she's tall, pretty and an underwear model. But don't judge her by her looks. In this fearless talk, she takes a wry look at the industry that had her looking highly seductive at barely 16 years old.", "2 Hours", 2, "https://cdn.vox-cdn.com/thumbor/CNLDJd5-M-WtOsYh_yugQ-S-FJs=/715x248:1689x721/1400x933/filters:focal(972x299:1278x605):no_upscale()/cdn.vox-cdn.com/uploads/chorus_image/image/69305239/shrek4_disneyscreencaps.com_675.0.jpg", "Looks aren't everything, Believe Me. I'm a Model.", 100, "Tuesday, July 1, 2021 2:30:00 PM" },
                    { 19099, "In a culture where being social and outgoing are prized above all else, it can be difficult, even shameful, to be an introvert. But, as Susan Cain argues in this passionate talk, introverts bring extraordinary talents and abilities to the world, and should be encouraged and celebrated.", "2 Hours", 2, "https://i.insider.com/53eccec469beddaa722af1d8?width=1000&format=jpeg&auto=webp", "The Power of Introverts", 1, "Monday, July 22, 2021 9:00:00 PM" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 12223);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 19099);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 2,
                column: "EventId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 4,
                column: "EventId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 7,
                column: "EventId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 10,
                column: "EventId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 12,
                column: "EventId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 13,
                column: "EventId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 77,
                column: "EventId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 407,
                column: "EventId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 666,
                column: "EventId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Description", "Duration", "HallId", "Image", "Name", "PresentorId", "Time" },
                values: new object[] { 122222, "Entrepreneur Elon Musk is a man with many plans. The founder of PayPal, Tesla Motors and SpaceX sits down with TED curator Chris Anderson to share details about his visionary projects, which include a mass-marketed electric car, a solar energy leasing company and a fully reusable rocket.", "2 Hours", 1, "https://c.ndtvimg.com/2021-03/9op9k9ko_elon-musk-reuters_625x300_25_March_21.jpg", "the Mind Behind Tesla, Spacex and Solarcity", 2, "Sunday, August 12, 2021 3:30:00 PM" });
        }
    }
}
