using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HuntShowdownAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "weapons",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    cost = table.Column<string>(type: "text", nullable: false),
                    unlock_condition = table.Column<string>(type: "text", nullable: false),
                    ammunition = table.Column<string>(type: "text", nullable: false),
                    capacity = table.Column<string>(type: "text", nullable: false),
                    damage = table.Column<int>(type: "integer", nullable: false),
                    rate_of_fire = table.Column<string>(type: "text", nullable: false),
                    reload_speed = table.Column<string>(type: "text", nullable: false),
                    melee_damage = table.Column<int>(type: "integer", nullable: false),
                    effective_range = table.Column<string>(type: "text", nullable: false),
                    handling = table.Column<string>(type: "text", nullable: false),
                    muzzle_velocity = table.Column<string>(type: "text", nullable: false),
                    heavy_melee_damage = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_weapons", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "weapons");
        }
    }
}
