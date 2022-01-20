using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace code_first_db_ci_cd.Migrations
{
    public partial class AddCompanyToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Company",
                table: "User");
        }
    }
}
