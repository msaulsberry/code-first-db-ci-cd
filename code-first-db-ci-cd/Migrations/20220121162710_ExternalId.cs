using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_first_db_ci_cd.Migrations
{
    public partial class ExternalId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExternalId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "User");
        }
    }
}
