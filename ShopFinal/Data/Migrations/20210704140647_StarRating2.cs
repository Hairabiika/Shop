using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopFinal.Data.Migrations
{
    public partial class StarRating2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublisheddDate",
                table: "ArticleComments");

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishedDate",
                table: "ArticleComments",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishedDate",
                table: "ArticleComments");

            migrationBuilder.AddColumn<DateTime>(
                name: "PublisheddDate",
                table: "ArticleComments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
