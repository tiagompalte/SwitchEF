using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SwitchEF.Infra.Data.Migrations
{
    public partial class AddManyToManyUserGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identification_Users_UserId",
                table: "Identification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identification",
                table: "Identification");

            migrationBuilder.RenameTable(
                name: "Identification",
                newName: "Identifications");

            migrationBuilder.RenameIndex(
                name: "IX_Identification_UserId",
                table: "Identifications",
                newName: "IX_Identifications_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Postings",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Postings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identifications",
                table: "Identifications",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 100, nullable: false),
                    PhotoUrl = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    DateCreated = table.Column<DateTime>(nullable: false),
                    Admin = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => new { x.UserId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_UserGroups_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserGroups_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Postings_GroupId",
                table: "Postings",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_GroupId",
                table: "UserGroups",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Identifications_Users_UserId",
                table: "Identifications",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postings_Groups_GroupId",
                table: "Postings",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Identifications_Users_UserId",
                table: "Identifications");

            migrationBuilder.DropForeignKey(
                name: "FK_Postings_Groups_GroupId",
                table: "Postings");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropIndex(
                name: "IX_Postings_GroupId",
                table: "Postings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Identifications",
                table: "Identifications");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Postings");

            migrationBuilder.RenameTable(
                name: "Identifications",
                newName: "Identification");

            migrationBuilder.RenameIndex(
                name: "IX_Identifications_UserId",
                table: "Identification",
                newName: "IX_Identification_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Postings",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 400);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Identification",
                table: "Identification",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Identification_Users_UserId",
                table: "Identification",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
