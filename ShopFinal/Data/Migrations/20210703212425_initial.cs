using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopFinal.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
