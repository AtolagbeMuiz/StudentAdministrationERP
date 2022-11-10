using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAdministrationERP.Migrations
{
    public partial class addedforignkeytostudententity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Degree_Id",
                table: "Student",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_Degree_Id",
                table: "Student",
                column: "Degree_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Degree_Degree_Id",
                table: "Student",
                column: "Degree_Id",
                principalTable: "Degree",
                principalColumn: "Degree_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Degree_Degree_Id",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_Degree_Id",
                table: "Student");

            migrationBuilder.AlterColumn<string>(
                name: "Degree_Id",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
