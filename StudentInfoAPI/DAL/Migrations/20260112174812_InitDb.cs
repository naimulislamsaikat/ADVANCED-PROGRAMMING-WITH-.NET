using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Depertments",
                columns: table => new
                {
                    DepertmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepertmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepertmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepertmentFacultyList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Student = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Depertments", x => x.DepertmentId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepertmentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Semester = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Depertment = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Depertments_Depertment",
                        column: x => x.Depertment,
                        principalTable: "Depertments",
                        principalColumn: "DepertmentId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Depertments_Student",
                table: "Depertments",
                column: "Student");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Depertment",
                table: "Students",
                column: "Depertment");

            migrationBuilder.AddForeignKey(
                name: "FK_Depertments_Students_Student",
                table: "Depertments",
                column: "Student",
                principalTable: "Students",
                principalColumn: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Depertments_Students_Student",
                table: "Depertments");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Depertments");
        }
    }
}
