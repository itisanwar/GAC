using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeExerciseGAC.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCustomers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblManufacturer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ManufacName = table.Column<string>(nullable: true),
                    ManufacLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblManufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(nullable: true),
                    Dimension = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblSalesOrder",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrderNo = table.Column<string>(nullable: true),
                    CustRef = table.Column<string>(nullable: true),
                    CustomersId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSalesOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblSalesOrder_tblCustomers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "tblCustomers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblSalesOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SalesOrderId = table.Column<int>(nullable: false),
                    ProductsId = table.Column<int>(nullable: false),
                    Qty = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblSalesOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblSalesOrderDetails_tblProducts_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "tblProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tblSalesOrderDetails_tblSalesOrder_SalesOrderId",
                        column: x => x.SalesOrderId,
                        principalTable: "tblSalesOrder",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblSalesOrder_CustomersId",
                table: "tblSalesOrder",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSalesOrderDetails_ProductsId",
                table: "tblSalesOrderDetails",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_tblSalesOrderDetails_SalesOrderId",
                table: "tblSalesOrderDetails",
                column: "SalesOrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblManufacturer");

            migrationBuilder.DropTable(
                name: "tblSalesOrderDetails");

            migrationBuilder.DropTable(
                name: "tblProducts");

            migrationBuilder.DropTable(
                name: "tblSalesOrder");

            migrationBuilder.DropTable(
                name: "tblCustomers");
        }
    }
}
