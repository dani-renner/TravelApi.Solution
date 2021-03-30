using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TravelApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Country = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    City = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Text = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationId", "City", "Country" },
                values: new object[,]
                {
                    { 1, "Seattle", "USA" },
                    { 2, "Victoria", "Canada" },
                    { 3, "Paris", "France" },
                    { 4, "Hoi An", "Vietnam" },
                    { 6, "Beijing", "China" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "LocationId", "Rating", "Text", "Title" },
                values: new object[] { 2, 1, 5, "Some more text", "Another Title" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "LocationId", "Rating", "Text", "Title" },
                values: new object[] { 1, 2, 1, "Some text", "A title" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "LocationId", "Rating", "Text", "Title" },
                values: new object[] { 3, 3, 4, "The most text text yet!", "Yet Another Title" });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_LocationId",
                table: "Reviews",
                column: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
