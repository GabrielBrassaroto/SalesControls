using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesControls.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    SaleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductDescripton = table.Column<string>(nullable: true),
                    DateBuy = table.Column<DateTime>(nullable: true),
                    DateSale = table.Column<DateTime>(nullable: true),
                    PriceSale = table.Column<double>(nullable: true),
                    PriceBuy = table.Column<double>(nullable: true),
                    DeliveryDate = table.Column<DateTime>(nullable: true),
                    TrackingCode = table.Column<string>(nullable: true),
                    PurchaseEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.SaleId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sale");
        }
    }
}
