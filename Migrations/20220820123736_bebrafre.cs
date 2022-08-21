using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zachem.Migrations
{
    public partial class bebrafre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Places_Jobs_ProffessionId",
                table: "Places");

            migrationBuilder.DropForeignKey(
                name: "FK_Places_Users_UserId",
                table: "Places");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Places",
                table: "Places");

            migrationBuilder.RenameTable(
                name: "Places",
                newName: "Members");

            migrationBuilder.RenameIndex(
                name: "IX_Places_UserId",
                table: "Members",
                newName: "IX_Members_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Places_ProffessionId",
                table: "Members",
                newName: "IX_Members_ProffessionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Members",
                table: "Members",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Jobs_ProffessionId",
                table: "Members",
                column: "ProffessionId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Users_UserId",
                table: "Members",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Members_Jobs_ProffessionId",
                table: "Members");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_Users_UserId",
                table: "Members");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Members",
                table: "Members");

            migrationBuilder.RenameTable(
                name: "Members",
                newName: "Places");

            migrationBuilder.RenameIndex(
                name: "IX_Members_UserId",
                table: "Places",
                newName: "IX_Places_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Members_ProffessionId",
                table: "Places",
                newName: "IX_Places_ProffessionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Places",
                table: "Places",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Jobs_ProffessionId",
                table: "Places",
                column: "ProffessionId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Users_UserId",
                table: "Places",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
