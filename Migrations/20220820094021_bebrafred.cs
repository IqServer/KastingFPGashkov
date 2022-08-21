using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zachem.Migrations
{
    public partial class bebrafred : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kurators_Job_ProffessionId",
                table: "Kurators");

            migrationBuilder.DropForeignKey(
                name: "FK_Places_Job_ProffessionId",
                table: "Places");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Job",
                table: "Job");

            migrationBuilder.RenameTable(
                name: "Job",
                newName: "Jobs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jobs",
                table: "Jobs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kurators_Jobs_ProffessionId",
                table: "Kurators",
                column: "ProffessionId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Jobs_ProffessionId",
                table: "Places",
                column: "ProffessionId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kurators_Jobs_ProffessionId",
                table: "Kurators");

            migrationBuilder.DropForeignKey(
                name: "FK_Places_Jobs_ProffessionId",
                table: "Places");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Jobs",
                table: "Jobs");

            migrationBuilder.RenameTable(
                name: "Jobs",
                newName: "Job");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Job",
                table: "Job",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Kurators_Job_ProffessionId",
                table: "Kurators",
                column: "ProffessionId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Places_Job_ProffessionId",
                table: "Places",
                column: "ProffessionId",
                principalTable: "Job",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
