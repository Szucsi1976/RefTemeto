using Microsoft.EntityFrameworkCore.Migrations;

namespace RefTemeto.Migrations
{
    public partial class addSettlementToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "parcel",
                table: "Graves",
                newName: "Parcel");

            migrationBuilder.CreateTable(
                name: "Settelments",
                columns: table => new
                {
                    PostalCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Station = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settelments", x => x.PostalCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settelments");

            migrationBuilder.RenameColumn(
                name: "Parcel",
                table: "Graves",
                newName: "parcel");
        }
    }
}
