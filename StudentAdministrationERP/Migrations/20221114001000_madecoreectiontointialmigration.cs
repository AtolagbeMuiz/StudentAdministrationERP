using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAdministrationERP.Migrations
{
    public partial class madecoreectiontointialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrolment_Student_DtudentStudent_Id",
                table: "Enrolment");

            migrationBuilder.DropIndex(
                name: "IX_Enrolment_DtudentStudent_Id",
                table: "Enrolment");

            migrationBuilder.DropColumn(
                name: "DtudentStudent_Id",
                table: "Enrolment");

            migrationBuilder.AlterColumn<string>(
                name: "Student_Id",
                table: "Enrolment",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrolment_Student_Id",
                table: "Enrolment",
                column: "Student_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolment_Student_Student_Id",
                table: "Enrolment",
                column: "Student_Id",
                principalTable: "Student",
                principalColumn: "Student_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrolment_Student_Student_Id",
                table: "Enrolment");

            migrationBuilder.DropIndex(
                name: "IX_Enrolment_Student_Id",
                table: "Enrolment");

            migrationBuilder.AlterColumn<string>(
                name: "Student_Id",
                table: "Enrolment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DtudentStudent_Id",
                table: "Enrolment",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrolment_DtudentStudent_Id",
                table: "Enrolment",
                column: "DtudentStudent_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrolment_Student_DtudentStudent_Id",
                table: "Enrolment",
                column: "DtudentStudent_Id",
                principalTable: "Student",
                principalColumn: "Student_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
