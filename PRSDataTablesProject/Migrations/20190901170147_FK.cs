using Microsoft.EntityFrameworkCore.Migrations;

namespace PRSDataTablesProject.Migrations
{
    public partial class FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "MyProperty",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "vendorId",
                table: "MyProperty",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_VendorId",
                table: "Products",
                column: "VendorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MyProperty_ProductId",
                table: "MyProperty",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_MyProperty_UserId",
                table: "MyProperty",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MyProperty_vendorId",
                table: "MyProperty",
                column: "vendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyProperty_Products_ProductId",
                table: "MyProperty",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MyProperty_Users_UserId",
                table: "MyProperty",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyProperty_Vendors_vendorId",
                table: "MyProperty",
                column: "vendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Vendors_VendorId",
                table: "Products",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyProperty_Products_ProductId",
                table: "MyProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProperty_Users_UserId",
                table: "MyProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProperty_Vendors_vendorId",
                table: "MyProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Vendors_VendorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_VendorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_MyProperty_ProductId",
                table: "MyProperty");

            migrationBuilder.DropIndex(
                name: "IX_MyProperty_UserId",
                table: "MyProperty");

            migrationBuilder.DropIndex(
                name: "IX_MyProperty_vendorId",
                table: "MyProperty");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "MyProperty");

            migrationBuilder.DropColumn(
                name: "vendorId",
                table: "MyProperty");
        }
    }
}
