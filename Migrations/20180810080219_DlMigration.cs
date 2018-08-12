using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kodinet.Migrations
{
    public partial class DlMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Workers_PersonId",
                table: "Workers");

            migrationBuilder.RenameColumn(
                name: "POBox",
                table: "Person",
                newName: "Pobox");

            migrationBuilder.RenameColumn(
                name: "expirationDate",
                table: "DrivingLicences",
                newName: "ExpirationDate");

            migrationBuilder.AddColumn<Guid>(
                name: "PeronId",
                table: "DrivingLicences",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Workers_PersonId",
                table: "Workers",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Workers_PersonId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "PeronId",
                table: "DrivingLicences");

            migrationBuilder.RenameColumn(
                name: "Pobox",
                table: "Person",
                newName: "POBox");

            migrationBuilder.RenameColumn(
                name: "ExpirationDate",
                table: "DrivingLicences",
                newName: "expirationDate");

            migrationBuilder.CreateIndex(
                name: "IX_Workers_PersonId",
                table: "Workers",
                column: "PersonId",
                unique: true);
        }
    }
}
