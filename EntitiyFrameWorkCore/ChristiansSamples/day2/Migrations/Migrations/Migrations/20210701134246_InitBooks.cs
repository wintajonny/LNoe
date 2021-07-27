using Microsoft.EntityFrameworkCore.Migrations;

namespace Migrations.Migrations
{
    public partial class InitBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "sample pub", "title 1" },
                    { 18, "sample pub", "title 18" },
                    { 17, "sample pub", "title 17" },
                    { 16, "sample pub", "title 16" },
                    { 15, "sample pub", "title 15" },
                    { 14, "sample pub", "title 14" },
                    { 13, "sample pub", "title 13" },
                    { 12, "sample pub", "title 12" },
                    { 11, "sample pub", "title 11" },
                    { 10, "sample pub", "title 10" },
                    { 9, "sample pub", "title 9" },
                    { 8, "sample pub", "title 8" },
                    { 7, "sample pub", "title 7" },
                    { 6, "sample pub", "title 6" },
                    { 5, "sample pub", "title 5" },
                    { 4, "sample pub", "title 4" },
                    { 3, "sample pub", "title 3" },
                    { 2, "sample pub", "title 2" },
                    { 19, "sample pub", "title 19" },
                    { 20, "sample pub", "title 20" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
