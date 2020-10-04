using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Identity.Migrations
{
    public partial class Updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DispalyName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "DispalyName",
                table: "AspNetUsers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
