using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OdeToFood.Data.Migrations
{
    public partial class AddOdeToFoodUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FavoriteRestaurant",
                table: "AspNetUsers",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FavoriteRestaurant",
                table: "AspNetUsers");
        }
    }
}
