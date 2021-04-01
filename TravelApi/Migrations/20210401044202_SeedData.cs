using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "City", "Country" },
                values: new object[,]
                {
                    { 1, "Bulawayo", "Zimbabwe" },
                    { 2, "Rosario", "Argentina" },
                    { 3, "Luxembourg", "Luxembourg" },
                    { 4, "Bharatpur", "Nepal" },
                    { 5, "Almaty", "Kazakhstan" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "LocationId", "Rating", "Text", "Title" },
                values: new object[,]
                {
                    { 1, 1, 3, "Every day is comfortable and beautiful outside. But water supply is a big problem.", "Perfect Weather!" },
                    { 2, 2, 3, "Every day is comfortable and beautiful outside. But there is crime and violence.", "Gorgeous Weather!" },
                    { 3, 3, 2, "The rent is too damned high!", "Gloomy & Expensive!" },
                    { 4, 4, 5, "There are wonderful flavors and spices here, and it's not too intense!", "Love the food!" },
                    { 5, 5, 1, "The men here sure are not respectful to women!", "Ladies, don't go!" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: 5);
        }
    }
}
