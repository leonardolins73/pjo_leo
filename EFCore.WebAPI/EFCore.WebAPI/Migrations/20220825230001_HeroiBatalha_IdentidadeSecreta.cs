using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.WebAPI.Migrations
{
    public partial class HeroiBatalha_IdentidadeSecreta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Herois_Batalhas_BatalhaID",
                table: "Herois");

            migrationBuilder.DropIndex(
                name: "IX_Herois_BatalhaID",
                table: "Herois");

            migrationBuilder.DropColumn(
                name: "BatalhaID",
                table: "Herois");

            migrationBuilder.AddColumn<int>(
                name: "HeroiBatalhaBatalhaId",
                table: "Herois",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HeroiBatalhaHeroiId",
                table: "Herois",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HeroiBatalhaBatalhaId",
                table: "Batalhas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HeroiBatalhaHeroiId",
                table: "Batalhas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdentidadeSecretaId",
                table: "Armas",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IdentidadesSecretas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeReal = table.Column<string>(nullable: true),
                    IdentidadeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentidadesSecretas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdentidadesSecretas_IdentidadesSecretas_IdentidadeId",
                        column: x => x.IdentidadeId,
                        principalTable: "IdentidadesSecretas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HeroisBatalhas",
                columns: table => new
                {
                    HeroiId = table.Column<int>(nullable: false),
                    BatalhaId = table.Column<int>(nullable: false),
                    IdentidadeSecretaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeroisBatalhas", x => new { x.BatalhaId, x.HeroiId });
                    table.ForeignKey(
                        name: "FK_HeroisBatalhas_IdentidadesSecretas_IdentidadeSecretaId",
                        column: x => x.IdentidadeSecretaId,
                        principalTable: "IdentidadesSecretas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Herois_HeroiBatalhaBatalhaId_HeroiBatalhaHeroiId",
                table: "Herois",
                columns: new[] { "HeroiBatalhaBatalhaId", "HeroiBatalhaHeroiId" });

            migrationBuilder.CreateIndex(
                name: "IX_Batalhas_HeroiBatalhaBatalhaId_HeroiBatalhaHeroiId",
                table: "Batalhas",
                columns: new[] { "HeroiBatalhaBatalhaId", "HeroiBatalhaHeroiId" });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_IdentidadeSecretaId",
                table: "Armas",
                column: "IdentidadeSecretaId");

            migrationBuilder.CreateIndex(
                name: "IX_HeroisBatalhas_IdentidadeSecretaId",
                table: "HeroisBatalhas",
                column: "IdentidadeSecretaId");

            migrationBuilder.CreateIndex(
                name: "IX_IdentidadesSecretas_IdentidadeId",
                table: "IdentidadesSecretas",
                column: "IdentidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_IdentidadesSecretas_IdentidadeSecretaId",
                table: "Armas",
                column: "IdentidadeSecretaId",
                principalTable: "IdentidadesSecretas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Batalhas_HeroisBatalhas_HeroiBatalhaBatalhaId_HeroiBatalhaHeroiId",
                table: "Batalhas",
                columns: new[] { "HeroiBatalhaBatalhaId", "HeroiBatalhaHeroiId" },
                principalTable: "HeroisBatalhas",
                principalColumns: new[] { "BatalhaId", "HeroiId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Herois_HeroisBatalhas_HeroiBatalhaBatalhaId_HeroiBatalhaHeroiId",
                table: "Herois",
                columns: new[] { "HeroiBatalhaBatalhaId", "HeroiBatalhaHeroiId" },
                principalTable: "HeroisBatalhas",
                principalColumns: new[] { "BatalhaId", "HeroiId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_IdentidadesSecretas_IdentidadeSecretaId",
                table: "Armas");

            migrationBuilder.DropForeignKey(
                name: "FK_Batalhas_HeroisBatalhas_HeroiBatalhaBatalhaId_HeroiBatalhaHeroiId",
                table: "Batalhas");

            migrationBuilder.DropForeignKey(
                name: "FK_Herois_HeroisBatalhas_HeroiBatalhaBatalhaId_HeroiBatalhaHeroiId",
                table: "Herois");

            migrationBuilder.DropTable(
                name: "HeroisBatalhas");

            migrationBuilder.DropTable(
                name: "IdentidadesSecretas");

            migrationBuilder.DropIndex(
                name: "IX_Herois_HeroiBatalhaBatalhaId_HeroiBatalhaHeroiId",
                table: "Herois");

            migrationBuilder.DropIndex(
                name: "IX_Batalhas_HeroiBatalhaBatalhaId_HeroiBatalhaHeroiId",
                table: "Batalhas");

            migrationBuilder.DropIndex(
                name: "IX_Armas_IdentidadeSecretaId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "HeroiBatalhaBatalhaId",
                table: "Herois");

            migrationBuilder.DropColumn(
                name: "HeroiBatalhaHeroiId",
                table: "Herois");

            migrationBuilder.DropColumn(
                name: "HeroiBatalhaBatalhaId",
                table: "Batalhas");

            migrationBuilder.DropColumn(
                name: "HeroiBatalhaHeroiId",
                table: "Batalhas");

            migrationBuilder.DropColumn(
                name: "IdentidadeSecretaId",
                table: "Armas");

            migrationBuilder.AddColumn<int>(
                name: "BatalhaID",
                table: "Herois",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Herois_BatalhaID",
                table: "Herois",
                column: "BatalhaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Herois_Batalhas_BatalhaID",
                table: "Herois",
                column: "BatalhaID",
                principalTable: "Batalhas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
