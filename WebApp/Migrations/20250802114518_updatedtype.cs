using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class updatedtype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookPrices_BookPriceId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Currencys_CurrencyId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookPriceId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencys",
                table: "Currencys");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "BookPriceId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Dollar",
                table: "Currencys");

            migrationBuilder.DropColumn(
                name: "Euro",
                table: "Currencys");

            migrationBuilder.DropColumn(
                name: "Rupees",
                table: "Currencys");

            migrationBuilder.RenameTable(
                name: "Currencys",
                newName: "Currencies");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Languages",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyId",
                table: "Books",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<DateTime>(
                name: "Createdon",
                table: "Books",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "BookPrices",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "BookPrices",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Currencies",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Currencies",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Indian INR", "INR" },
                    { 2, "US Dollar", "Dollar" },
                    { 3, "Euro", "Euro" },
                    { 4, "Dinar", "Dinar" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookPrices_BookId",
                table: "BookPrices",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookPrices_CurrencyId",
                table: "BookPrices",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookPrices_Books_BookId",
                table: "BookPrices",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookPrices_Currencies_CurrencyId",
                table: "BookPrices",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Currencies_CurrencyId",
                table: "Books",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookPrices_Books_BookId",
                table: "BookPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_BookPrices_Currencies_CurrencyId",
                table: "BookPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Currencies_CurrencyId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_BookPrices_BookId",
                table: "BookPrices");

            migrationBuilder.DropIndex(
                name: "IX_BookPrices_CurrencyId",
                table: "BookPrices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies");

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Currencies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Createdon",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "BookPrices");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "BookPrices");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Currencies");

            migrationBuilder.RenameTable(
                name: "Currencies",
                newName: "Currencys");

            migrationBuilder.AlterColumn<int>(
                name: "Description",
                table: "Languages",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Languages",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "CurrencyId",
                table: "Books",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookPriceId",
                table: "Books",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dollar",
                table: "Currencys",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Euro",
                table: "Currencys",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rupees",
                table: "Currencys",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencys",
                table: "Currencys",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookPriceId",
                table: "Books",
                column: "BookPriceId");

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
    }
}
