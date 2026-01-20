using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class twice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckDetails_Students_StId",
                table: "CheckDetails");

            migrationBuilder.DropIndex(
                name: "IX_CheckDetails_StId",
                table: "CheckDetails");

            migrationBuilder.DropColumn(
                name: "StId",
                table: "CheckDetails");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StId",
                table: "CheckDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetails_StId",
                table: "CheckDetails",
                column: "StId");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckDetails_Students_StId",
                table: "CheckDetails",
                column: "StId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
