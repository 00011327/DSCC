using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryUI.Migrations
{
    /// <inheritdoc />
    public partial class initialmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "ISBN", "Title" },
                values: new object[,]
                {
                    { 1, "Толстой", "123456789", "Война и Мир" },
                    { 2, "J. K. Rowling", "12345678910", "Harry Potter Philosopher's Stone" },
                    { 3, "J. K. Rowling", "123456789a", "Harry Potter Chamber of Secrets" },
                    { 4, "J. K. Rowling", "123456789b", "Harry Potter CPrisoner of Azkaban" },
                    { 5, "J. K. Rowling", "123456789c", "Harry Potter Goblet of Fire" },
                    { 6, "J. K. Rowling", "123456789d", "Harry Potter Order of the Phoenix" },
                    { 7, "J. K. Rowling", "123456789e", "Harry Potter Half-Blood Prince" },
                    { 8, "J. K. Rowling", "123456789f", "Harry Potter Deathly Hallows" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
