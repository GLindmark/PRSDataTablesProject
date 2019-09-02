using Microsoft.EntityFrameworkCore.Migrations;

namespace PRSDataTablesProject.Migrations
{
    public partial class Unique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(11, 2)");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_Code",
                table: "Vendors",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Price",
                table: "Products",
                column: "Price",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Vendors_Code",
                table: "Vendors");

            migrationBuilder.DropIndex(
                name: "IX_Users_Username",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Products_Price",
                table: "Products");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(11, 2)",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}
