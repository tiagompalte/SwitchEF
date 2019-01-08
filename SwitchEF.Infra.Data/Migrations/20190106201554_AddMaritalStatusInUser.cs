using Microsoft.EntityFrameworkCore.Migrations;

namespace SwitchEF.Infra.Data.Migrations
{
    public partial class AddMaritalStatusInUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaritalStatus",
                table: "Users",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaritalStatus",
                table: "Users");
        }
    }
}
