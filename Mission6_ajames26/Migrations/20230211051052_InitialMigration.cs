using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_ajames26.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<uint>(type: "INTEGER", nullable: false),
                    Director = table.Column<string>(type: "TEXT", nullable: false),
                    Rating = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    Edited = table.Column<bool>(type: "INTEGER", nullable: false),
                    LentTo = table.Column<string>(type: "TEXT", nullable: true),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Comedy", "Brian Levant", false, null, null, "PG", "The Spy Next Door", 2010u });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action", "Chad Stahelski", false, null, null, "R", "John Wick", 2014u });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "Steven Spielberg", false, null, null, "PG", "Raiders of the Lost Ark", 1981u });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
