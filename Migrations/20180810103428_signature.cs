using Microsoft.EntityFrameworkCore.Migrations;

namespace Kodinet.Migrations
{
    public partial class signature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpirationDate",
                table: "DrivingLicences",
                newName: "expirationDate");

            migrationBuilder.AddColumn<string>(
                name: "Signature",
                table: "Person",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Signature",
                table: "Person");

            migrationBuilder.RenameColumn(
                name: "expirationDate",
                table: "DrivingLicences",
                newName: "ExpirationDate");
        }
    }
}
