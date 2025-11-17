using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App1.Migrations
{
    /// <inheritdoc />
    public partial class category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "categoryId",
                table: "proudcts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "catgoreyId",
                table: "proudcts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Catgorey",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catgorey", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_proudcts_catgoreyId",
                table: "proudcts",
                column: "catgoreyId");

            migrationBuilder.AddForeignKey(
                name: "FK_proudcts_Catgorey_catgoreyId",
                table: "proudcts",
                column: "catgoreyId",
                principalTable: "Catgorey",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_proudcts_Catgorey_catgoreyId",
                table: "proudcts");

            migrationBuilder.DropTable(
                name: "Catgorey");

            migrationBuilder.DropIndex(
                name: "IX_proudcts_catgoreyId",
                table: "proudcts");

            migrationBuilder.DropColumn(
                name: "categoryId",
                table: "proudcts");

            migrationBuilder.DropColumn(
                name: "catgoreyId",
                table: "proudcts");
        }
    }
}
