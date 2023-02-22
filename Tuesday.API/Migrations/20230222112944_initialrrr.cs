using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tuesday.API.Migrations
{
    public partial class initialrrr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Personid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Car_Person_Personid",
                        column: x => x.Personid,
                        principalTable: "Person",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Car_Personid",
                table: "Car",
                column: "Personid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");
        }
    }
}
