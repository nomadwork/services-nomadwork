using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nomadwork.Infra.Data.Migrations
{
    public partial class TesteLocal1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Active = table.Column<short>(nullable: false),
                    Zipcode = table.Column<string>(type: "varchar(15)", nullable: true),
                    Street = table.Column<string>(type: "varchar(100)", nullable: false),
                    Number = table.Column<string>(type: "varchar(10)", nullable: false),
                    Coutry = table.Column<string>(type: "varchar(30)", nullable: false),
                    State = table.Column<string>(type: "varchar(30)", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(8,8)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(8,8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Establishment",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Active = table.Column<short>(nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", nullable: true),
                    Phone = table.Column<string>(type: "varchar(20)", nullable: false),
                    TimeOpen = table.Column<DateTime>(nullable: false),
                    TimeClose = table.Column<DateTime>(nullable: false),
                    AddressId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Establishment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Establishment_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Active = table.Column<short>(nullable: false),
                    UrlPhoto = table.Column<string>(nullable: false),
                    EstablishmentModelDataId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Establishment_EstablishmentModelDataId",
                        column: x => x.EstablishmentModelDataId,
                        principalTable: "Establishment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Establishment_AddressId",
                table: "Establishment",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_EstablishmentModelDataId",
                table: "Photos",
                column: "EstablishmentModelDataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Establishment");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
