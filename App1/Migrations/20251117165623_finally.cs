using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App1.Migrations
{
    /// <inheritdoc />
    public partial class @finally : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proudcts_categories_CategoryId",
                table: "proudcts");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "proudcts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_proudcts_categories_CategoryId",
                table: "proudcts",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proudcts_categories_CategoryId",
                table: "proudcts");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "proudcts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_proudcts_categories_CategoryId",
                table: "proudcts",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
