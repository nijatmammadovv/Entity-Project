using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity_Project.Migrations
{
    public partial class CreatedBooksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    PageCount = table.Column<int>(nullable: false),
                    StockCount = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    PublisingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Publisings_PublisingId",
                        column: x => x.PublisingId,
                        principalTable: "Publisings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisingId",
                table: "Books",
                column: "PublisingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
