using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MOVIES",
                columns: table => new
                {
                    MOVIE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NAME = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    SHORT_DESCRIPTION = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    DESCRIPTION = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    RELEASE_DATE = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    GENRE = table.Column<int>(type: "int", nullable: false),
                    DURATION = table.Column<decimal>(type: "DECIMAL(4,0)", nullable: false),
                    DIRECTOR = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOVIES", x => x.MOVIE_ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MOVIES_NAME",
                table: "MOVIES",
                column: "NAME",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MOVIES");
        }
    }
}
