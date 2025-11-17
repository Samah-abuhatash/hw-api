using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App1.Migrations
{
    /// <inheritdoc />
    public partial class NameOfYourMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proudcts_Catgorey_catgoreyId",
                table: "proudcts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Catgorey",
                table: "Catgorey");

            migrationBuilder.RenameTable(
                name: "Catgorey",
                newName: "categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_proudcts_categories_catgoreyId",
                table: "proudcts",
                column: "catgoreyId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proudcts_categories_catgoreyId",
                table: "proudcts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "Catgorey");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Catgorey",
                table: "Catgorey",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_proudcts_Catgorey_catgoreyId",
                table: "proudcts",
                column: "catgoreyId",
                principalTable: "Catgorey",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
