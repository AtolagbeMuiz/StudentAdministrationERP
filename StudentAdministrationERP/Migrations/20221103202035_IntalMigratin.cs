using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAdministrationERP.Migrations
{
    public partial class IntalMigratin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Degree",
                columns: table => new
                {
                    Degree_Id = table.Column<string>(nullable: false),
                    Degree_Title = table.Column<string>(nullable: true),
                    NoOfYears = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degree", x => x.Degree_Id);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Student_Id = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Degree_Id = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    isEnrolled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Student_Id);
                });

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    Module_Id = table.Column<Guid>(nullable: false),
                    Module_Code = table.Column<int>(nullable: false),
                    Module_Title = table.Column<string>(nullable: true),
                    Degree_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.Module_Id);
                    table.ForeignKey(
                        name: "FK_Module_Degree_Degree_Id",
                        column: x => x.Degree_Id,
                        principalTable: "Degree",
                        principalColumn: "Degree_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Module_Degree_Id",
                table: "Module",
                column: "Degree_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Module");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Degree");
        }
    }
}
