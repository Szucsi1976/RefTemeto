using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RefTemeto.Migrations
{
    public partial class AddBurialToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Settelments",
                table: "Settelments");

            migrationBuilder.RenameTable(
                name: "Settelments",
                newName: "Settlements");

            migrationBuilder.AlterColumn<int>(
                name: "PostalCode",
                table: "Settlements",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Settlements",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Settlements",
                table: "Settlements",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Burials",
                columns: table => new
                {
                    FuneralId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuneralName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuneralDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Undertaker = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burials", x => x.FuneralId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Burials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Settlements",
                table: "Settlements");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Settlements");

            migrationBuilder.RenameTable(
                name: "Settlements",
                newName: "Settelments");

            migrationBuilder.AlterColumn<int>(
                name: "PostalCode",
                table: "Settelments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Settelments",
                table: "Settelments",
                column: "PostalCode");
        }
    }
}
