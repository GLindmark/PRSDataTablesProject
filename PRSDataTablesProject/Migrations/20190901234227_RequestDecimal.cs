using Microsoft.EntityFrameworkCore.Migrations;

namespace PRSDataTablesProject.Migrations
{
    public partial class RequestDecimal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "MyProperty",
                type: "decimal(11, 2)",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "MyProperty",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(11, 2)");
        }
    }
}
