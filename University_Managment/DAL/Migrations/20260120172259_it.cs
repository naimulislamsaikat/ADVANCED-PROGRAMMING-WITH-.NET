using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class it : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CheckDetails",
                columns: table => new
                {
                    CDId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StId = table.Column<int>(type: "int", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false),
                    DepId = table.Column<int>(type: "int", nullable: false),
                    CId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckDetails", x => x.CDId);
                    table.ForeignKey(
                        name: "FK_CheckDetails_Courses_CId",
                        column: x => x.CId,
                        principalTable: "Courses",
                        principalColumn: "CId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckDetails_Depertments_DepId",
                        column: x => x.DepId,
                        principalTable: "Depertments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckDetails_Payments_PId",
                        column: x => x.PId,
                        principalTable: "Payments",
                        principalColumn: "PId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckDetails_Students_StId",
                        column: x => x.StId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CheckDetails_StId",
                table: "CheckDetails",
                column: "StId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckDetails");
        }
    }
}
