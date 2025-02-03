/*using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bokhandel_console.Migrations
{
    /// <inheritdoc />
    public partial class AddForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Butiker",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Butiksnamn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Butiker", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Författar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Förnamn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Efternamn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Födelsedatum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Författar", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Böcker",
                columns: table => new
                {
                    ISBN13 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Titel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Språk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pris = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Utgivningsdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FörfattareID = table.Column<int>(type: "int", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Böcker", x => x.ISBN13);
                    table.ForeignKey(
                        name: "FK_Böcker_Författar_FörfattareID",
                        column: x => x.FörfattareID,
                        principalTable: "Författar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lagersaldo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ButikID = table.Column<int>(type: "int", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BokISBN13 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Antal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lagersaldo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Lagersaldo_Butiker_ButikID",
                        column: x => x.ButikID,
                        principalTable: "Butiker",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lagersaldo_Böcker_BokISBN13",
                        column: x => x.BokISBN13,
                        principalTable: "Böcker",
                        principalColumn: "ISBN13");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Böcker_FörfattareID",
                table: "Böcker",
                column: "FörfattareID");

            migrationBuilder.CreateIndex(
                name: "IX_Lagersaldo_BokISBN13",
                table: "Lagersaldo",
                column: "BokISBN13");

            migrationBuilder.CreateIndex(
                name: "IX_Lagersaldo_ButikID",
                table: "Lagersaldo",
                column: "ButikID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lagersaldo");

            migrationBuilder.DropTable(
                name: "Butiker");

            migrationBuilder.DropTable(
                name: "Böcker");

            migrationBuilder.DropTable(
                name: "Författar");
        }
    }
}
*/