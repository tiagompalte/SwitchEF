using Microsoft.EntityFrameworkCore.Migrations;

namespace SwitchEF.Infra.Data.Migrations
{
    public partial class AddPostingsInUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Postings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Postings_UserId",
                table: "Postings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Postings_Users_UserId",
                table: "Postings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postings_Users_UserId",
                table: "Postings");

            migrationBuilder.DropIndex(
                name: "IX_Postings_UserId",
                table: "Postings");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Postings");
        }
    }
}
