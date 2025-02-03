/*using Microsoft.EntityFrameworkCore.Migrations;

public partial class UpdateLagersaldoSchema : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        // Drop foreign key and table if exists
        migrationBuilder.DropForeignKey(
            name: "FK_Böcker_Författar_FörfattareID",
            table: "Böcker");

        // Drop the old Författar table if it exists
        migrationBuilder.DropTable(
            name: "Författar");

        // Create the Författare table
        migrationBuilder.CreateTable(
            name: "Författare",
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
                table.PrimaryKey("PK_Författare", x => x.ID);
            });

        // Create the Customers table
        migrationBuilder.CreateTable(
            name: "Customers",
            columns: table => new
            {
                ID = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                förnamn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Andranamn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Telefonnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Favoritgenre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                FavoritförfattareID = table.Column<int>(type: "int", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Customers", x => x.ID);
                table.ForeignKey(
                    name: "FK_Customers_Författare_FavoritförfattareID",
                    column: x => x.FavoritförfattareID,
                    principalTable: "Författare",
                    principalColumn: "ID");
            });

        // Create the Ordrar table
        migrationBuilder.CreateTable(
            name: "Ordrar",
            columns: table => new
            {
                ID = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                CustomerID = table.Column<int>(type: "int", nullable: false),
                Orderdatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                Totalamount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Ordrar", x => x.ID);
                table.ForeignKey(
                    name: "FK_Ordrar_Customers_CustomerID",
                    column: x => x.CustomerID,
                    principalTable: "Customers",
                    principalColumn: "ID",
                    onDelete: ReferentialAction.Cascade);
            });

        // Create necessary indexes
        migrationBuilder.CreateIndex(
            name: "IX_Customers_FavoritförfattareID",
            table: "Customers",
            column: "FavoritförfattareID");

        migrationBuilder.CreateIndex(
            name: "IX_Ordrar_CustomerID",
            table: "Ordrar",
            column: "CustomerID");

        // Add back the foreign key for Böcker table
        migrationBuilder.AddForeignKey(
            name: "FK_Böcker_Författare_FörfattareID",
            table: "Böcker",
            column: "FörfattareID",
            principalTable: "Författare",
            principalColumn: "ID",
            onDelete: ReferentialAction.Cascade);
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropForeignKey(
            name: "FK_Böcker_Författare_FörfattareID",
            table: "Böcker");

        migrationBuilder.DropTable(
            name: "Ordrar");

        migrationBuilder.DropTable(
            name: "Customers");

        migrationBuilder.DropTable(
            name: "Författare");

        migrationBuilder.CreateTable(
            name: "Författar",
            columns: table => new
            {
                ID = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Efternamn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                Födelsedatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                Förnamn = table.Column<string>(type: "nvarchar(max)", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Författar", x => x.ID);
            });

        migrationBuilder.AddForeignKey(
            name: "FK_Böcker_Författar_FörfattareID",
            table: "Böcker",
            column: "FörfattareID",
            principalTable: "Författar",
            principalColumn: "ID",
            onDelete: ReferentialAction.Cascade);
    }
}
*/