using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class UpdateDatabaseStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantityxInStock",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "QuantityInStock",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantityInStock",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "QuantityxInStock",
                table: "Products",
                type: "TEXT",
                nullable: true);
        }
    }
}
