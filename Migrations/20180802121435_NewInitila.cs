using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kodinet.Migrations
{
    public partial class NewInitila : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    POBox = table.Column<string>(nullable: true),
                    Prov = table.Column<string>(nullable: true),
                    TownDist = table.Column<string>(nullable: true),
                    Commune = table.Column<string>(nullable: true),
                    QuarterSect = table.Column<string>(nullable: true),
                    AvenueLoc = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    ChipNumber = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: true),
                    FingerPrintId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    NickName = table.Column<string>(nullable: true),
                    BirthPlace = table.Column<string>(nullable: true),
                    BirthDate = table.Column<string>(nullable: true),
                    Nationality = table.Column<string>(nullable: true),
                    IdNumber = table.Column<string>(nullable: true),
                    Photo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DrivingLicences",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DlNumber = table.Column<string>(nullable: true),
                    PlaceOfIssue = table.Column<string>(nullable: true),
                    DateOfIssue = table.Column<string>(nullable: true),
                    expirationDate = table.Column<DateTime>(nullable: false),
                    CertificateNumber = table.Column<int>(nullable: false),
                    CategoryA = table.Column<bool>(nullable: false),
                    CategoryB = table.Column<bool>(nullable: false),
                    CategoryC = table.Column<bool>(nullable: false),
                    CategoryD = table.Column<bool>(nullable: false),
                    CategoryE = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrivingLicences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrivingLicences_Person_Id",
                        column: x => x.Id,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    WorkerId = table.Column<Guid>(nullable: false),
                    EntityId = table.Column<int>(nullable: false),
                    JobDescription = table.Column<string>(nullable: true),
                    GradeId = table.Column<string>(nullable: true),
                    PersonId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.WorkerId);
                    table.ForeignKey(
                        name: "FK_Workers_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workers_PersonId",
                table: "Workers",
                column: "PersonId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrivingLicences");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
