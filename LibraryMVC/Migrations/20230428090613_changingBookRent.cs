using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryMVC.Migrations
{
    /// <inheritdoc />
    public partial class changingBookRent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookRents_BookRentId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookRentId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookRentId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "BookRents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookRents_BookId",
                table: "BookRents",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookRents_Books_BookId",
                table: "BookRents",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookRents_Books_BookId",
                table: "BookRents");

            migrationBuilder.DropIndex(
                name: "IX_BookRents_BookId",
                table: "BookRents");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "BookRents");

            migrationBuilder.AddColumn<int>(
                name: "BookRentId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookRentId",
                table: "Books",
                column: "BookRentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookRents_BookRentId",
                table: "Books",
                column: "BookRentId",
                principalTable: "BookRents",
                principalColumn: "Id");
        }
    }
}
