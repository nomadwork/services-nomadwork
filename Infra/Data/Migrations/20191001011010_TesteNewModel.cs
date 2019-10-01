using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nomadwork.Infra.Data.Migrations
{
    public partial class TesteNewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characteristic");

            migrationBuilder.AddColumn<string>(
                name: "ExtensionFile",
                table: "Photos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameFile",
                table: "Photos",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TimeOpen",
                table: "Establishment",
                type: "char(5)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "TimeClose",
                table: "Establishment",
                type: "char(5)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<short>(
                name: "Noise",
                table: "Establishment",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Plug",
                table: "Establishment",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "Wifi",
                table: "Establishment",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropColumn(
                name: "ExtensionFile",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "NameFile",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "Noise",
                table: "Establishment");

            migrationBuilder.DropColumn(
                name: "Plug",
                table: "Establishment");

            migrationBuilder.DropColumn(
                name: "Wifi",
                table: "Establishment");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeOpen",
                table: "Establishment",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(5)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeClose",
                table: "Establishment",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(5)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Characteristic",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    EstablishmentModelDataId = table.Column<long>(nullable: true),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    Quality = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Service = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characteristic_Establishment_EstablishmentModelDataId",
                        column: x => x.EstablishmentModelDataId,
                        principalTable: "Establishment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characteristic_EstablishmentModelDataId",
                table: "Characteristic",
                column: "EstablishmentModelDataId");
        }
    }
}
