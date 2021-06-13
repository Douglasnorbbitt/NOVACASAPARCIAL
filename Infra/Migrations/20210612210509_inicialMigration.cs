using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class inicialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalogos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "varchar", maxLength: 10, nullable: true),
                    TipoImovel = table.Column<string>(type: "varchar", maxLength: 100, nullable: true),
                    NumeroImovel = table.Column<string>(type: "varchar", maxLength: 10, nullable: false),
                    Rua = table.Column<string>(type: "varchar", maxLength: 100, nullable: true),
                    Bairro = table.Column<string>(type: "varchar", maxLength: 50, nullable: true),
                    Cidade = table.Column<string>(type: "varchar", maxLength: 80, nullable: true),
                    Estado = table.Column<string>(type: "varchar", maxLength: 50, nullable: true),
                    Cep = table.Column<string>(type: "varchar", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalogos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalogos");
        }
    }
}
