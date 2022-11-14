using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAdministrationERP.Migrations
{
    public partial class AddedEnromentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enrolment",
                columns: table => new
                {
                    Enrolment_Id = table.Column<Guid>(nullable: false),
                    Student_Id = table.Column<string>(nullable: true),
                    Module_Code = table.Column<int>(nullable: false),
                    DtudentStudent_Id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrolment", x => x.Enrolment_Id);
                    table.ForeignKey(
                        name: "FK_Enrolment_Student_DtudentStudent_Id",
                        column: x => x.DtudentStudent_Id,
                        principalTable: "Student",
                        principalColumn: "Student_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrolment_DtudentStudent_Id",
                table: "Enrolment",
                column: "DtudentStudent_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrolment");
        }
    }
}
