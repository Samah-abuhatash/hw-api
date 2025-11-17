using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proudcts_categories_catgoreyId",
                table: "proudcts");

            migrationBuilder.DropIndex(
                name: "IX_proudcts_catgoreyId",
                table: "proudcts");

            migrationBuilder.DropColumn(
                name: "catgoreyId",
                table: "proudcts");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "proudcts",
                newName: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_proudcts_CategoryId",
                table: "proudcts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_proudcts_categories_CategoryId",
                table: "proudcts",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proudcts_categories_CategoryId",
                table: "proudcts");

            migrationBuilder.DropIndex(
                name: "IX_proudcts_CategoryId",
                table: "proudcts");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "proudcts",
                newName: "categoryId");

            migrationBuilder.AddColumn<int>(
                name: "catgoreyId",
                table: "proudcts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_proudcts_catgoreyId",
                table: "proudcts",
                column: "catgoreyId");

            migrationBuilder.AddForeignKey(
                name: "FK_proudcts_categories_catgoreyId",
                table: "proudcts",
                column: "catgoreyId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
