using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kodinet.Migrations
{
    public partial class NewModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrivingLicences_Person_Id",
                table: "DrivingLicences");

            migrationBuilder.DropColumn(
                name: "WorkerId",
                table: "Person");

            migrationBuilder.AddColumn<Guid>(
                name: "IdNavigationId",
                table: "DrivingLicences",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DrivingLicences_IdNavigationId",
                table: "DrivingLicences",
                column: "IdNavigationId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrivingLicences_Person_IdNavigationId",
                table: "DrivingLicences",
                column: "IdNavigationId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrivingLicences_Person_IdNavigationId",
                table: "DrivingLicences");

            migrationBuilder.DropIndex(
                name: "IX_DrivingLicences_IdNavigationId",
                table: "DrivingLicences");

            migrationBuilder.DropColumn(
                name: "IdNavigationId",
                table: "DrivingLicences");

            migrationBuilder.AddColumn<Guid>(
                name: "WorkerId",
                table: "Person",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_DrivingLicences_Person_Id",
                table: "DrivingLicences",
                column: "Id",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
