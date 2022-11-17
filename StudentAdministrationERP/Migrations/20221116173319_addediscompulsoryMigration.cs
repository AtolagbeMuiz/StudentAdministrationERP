using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentAdministrationERP.Migrations
{
    public partial class addediscompulsoryMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isCompulsory",
                table: "Module",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isCompulsory",
                table: "Module");
        }
    }
}
