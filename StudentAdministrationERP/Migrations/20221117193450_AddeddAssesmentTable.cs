using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAdministrationERP.Migrations
{
    public partial class AddeddAssesmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assessment",
                columns: table => new
                {
                    Assessment_Id = table.Column<Guid>(nullable: false),
                    Assessment_Title = table.Column<string>(nullable: true),
                    Assessment_Mark = table.Column<double>(nullable: false),
                    Degree_Id = table.Column<string>(nullable: true),
                    Module_Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessment", x => x.Assessment_Id);
                    table.ForeignKey(
                        name: "FK_Assessment_Degree_Degree_Id",
                        column: x => x.Degree_Id,
                        principalTable: "Degree",
                        principalColumn: "Degree_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assessment_Module_Module_Id",
                        column: x => x.Module_Id,
                        principalTable: "Module",
                        principalColumn: "Module_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Degree_Id",
                table: "Assessment",
                column: "Degree_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Assessment_Module_Id",
                table: "Assessment",
                column: "Module_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assessment");
        }
    }
}
