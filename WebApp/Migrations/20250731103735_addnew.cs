using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class addnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookPriceId",
                table: "Books",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "Books",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BookPrices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookPrices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Rupees = table.Column<int>(type: "integer", nullable: false),
                    Dollar = table.Column<int>(type: "integer", nullable: false),
                    Euro = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencys", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookPriceId",
                table: "Books",
                column: "BookPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CurrencyId",
                table: "Books",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookPrices_BookPriceId",
                table: "Books",
                column: "BookPriceId",
                principalTable: "BookPrices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Currencys_CurrencyId",
                table: "Books",
                column: "CurrencyId",
                principalTable: "Currencys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookPrices_BookPriceId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Currencys_CurrencyId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "BookPrices");

            migrationBuilder.DropTable(
                name: "Currencys");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookPriceId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CurrencyId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookPriceId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Books");
        }
    }
}
