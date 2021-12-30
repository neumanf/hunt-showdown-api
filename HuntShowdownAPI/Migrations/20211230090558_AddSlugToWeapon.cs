using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HuntShowdownAPI.Migrations
{
    public partial class AddSlugToWeapon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "slug",
                table: "weapons",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "slug",
                table: "weapons");
        }
    }
}
