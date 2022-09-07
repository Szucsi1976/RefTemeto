using Microsoft.EntityFrameworkCore.Migrations;

namespace RefTemeto.Migrations
{
    public partial class addBurialsToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Burials",
                newName: "FuneralId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FuneralId",
                table: "Burials",
                newName: "Id");
        }
    }
}
