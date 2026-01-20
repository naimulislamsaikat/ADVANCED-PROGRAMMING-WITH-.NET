using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class once : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckDetails_Courses_CId",
                table: "CheckDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckDetails_Depertments_DepId",
                table: "CheckDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_CheckDetails_Payments_PId",
                table: "CheckDetails");

            migrationBuilder.DropIndex(
                name: "IX_CheckDetails_CId",
                table: "CheckDetails");

            migrationBuilder.DropIndex(
                name: "IX_CheckDetails_DepId",
                table: "CheckDetails");

            migrationBuilder.DropIndex(
                name: "IX_CheckDetails_PId",
                table: "CheckDetails");

            migrationBuilder.DropColumn(
                name: "CId",
                table: "CheckDetails");

            migrationBuilder.DropColumn(
                name: "DepId",
                table: "CheckDetails");

            migrationBuilder.DropColumn(
                name: "PId",
                table: "CheckDetails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CId",
                table: "CheckDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepId",
                table: "CheckDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PId",
                table: "CheckDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetails_CId",
                table: "CheckDetails",
                column: "CId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetails_DepId",
                table: "CheckDetails",
                column: "DepId");

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetails_PId",
                table: "CheckDetails",
                column: "PId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckDetails_Courses_CId",
                table: "CheckDetails",
                column: "CId",
                principalTable: "Courses",
                principalColumn: "CId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckDetails_Depertments_DepId",
                table: "CheckDetails",
                column: "DepId",
                principalTable: "Depertments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckDetails_Payments_PId",
                table: "CheckDetails",
                column: "PId",
                principalTable: "Payments",
                principalColumn: "PId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
