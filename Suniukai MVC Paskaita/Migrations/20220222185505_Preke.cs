using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Suniukai_MVC_Paskaita.Migrations
{
    public partial class Preke : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prekes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Pavadinimas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nuotrauka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aprasymas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kaina = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prekes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prekes");
        }
    }
}
