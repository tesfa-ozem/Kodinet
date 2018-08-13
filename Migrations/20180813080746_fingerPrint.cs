using Microsoft.EntityFrameworkCore.Migrations;

namespace Kodinet.Migrations
{
    public partial class fingerPrint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FingerPrint",
                table: "AppRegistrations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FingerPrint",
                table: "AppRegistrations");
        }
    }
}
