using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PRSDataTablesProject.Migrations
{
    public partial class Request : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Products_Price",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "Requests");

            migrationBuilder.RenameIndex(
                name: "IX_MyProperty_vendorId",
                table: "Requests",
                newName: "IX_Requests_vendorId");

            migrationBuilder.RenameIndex(
                name: "IX_MyProperty_UserId",
                table: "Requests",
                newName: "IX_Requests_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MyProperty_ProductId",
                table: "Requests",
                newName: "IX_Requests_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Requests",
                table: "Requests",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RequestLines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RequestIdId = table.Column<int>(nullable: false),
                    ProductIdId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestLines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestLines_Products_ProductIdId",
                        column: x => x.ProductIdId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestLines_Requests_RequestIdId",
                        column: x => x.RequestIdId,
                        principalTable: "Requests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_PartNbr",
                table: "Products",
                column: "PartNbr",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RequestLines_ProductIdId",
                table: "RequestLines",
                column: "ProductIdId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestLines_RequestIdId",
                table: "RequestLines",
                column: "RequestIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Products_ProductId",
                table: "Requests",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Vendors_vendorId",
                table: "Requests",
                column: "vendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Products_ProductId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Users_UserId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Vendors_vendorId",
                table: "Requests");

            migrationBuilder.DropTable(
                name: "RequestLines");

            migrationBuilder.DropIndex(
                name: "IX_Products_PartNbr",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Requests",
                table: "Requests");

            migrationBuilder.RenameTable(
                name: "Requests",
                newName: "MyProperty");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_vendorId",
                table: "MyProperty",
                newName: "IX_MyProperty_vendorId");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_UserId",
                table: "MyProperty",
                newName: "IX_MyProperty_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Requests_ProductId",
                table: "MyProperty",
                newName: "IX_MyProperty_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Price",
                table: "Products",
                column: "Price",
                unique: true);

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
        }
    }
}
