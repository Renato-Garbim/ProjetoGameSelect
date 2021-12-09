using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Game.Infra.Migrations
{
    public partial class Initial_Schemma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    EntidadeGameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EntidadeGameGuid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    titulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ano = table.Column<int>(type: "int", nullable: false),
                    nota = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.EntidadeGameId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "EntidadeGameId", "EntidadeGameGuid", "ano", "nota", "titulo" },
                values: new object[,]
                {
                    { 1, new Guid("c3247c57-d917-4cc5-a69c-90a19ceb5777"), 1998, 99.799999999999997, "The Legend of Zelda: Ocarina of Time(N64)" },
                    { 2, new Guid("6f01e281-04eb-4cb4-a32f-cc486b6c26b6"), 2000, 98.900000000000006, "Tony Hawk's Pro Skater 2 (PS)" },
                    { 3, new Guid("425108e6-b061-4434-a370-9f67d5324b22"), 2008, 98.900000000000006, "Grand Theft Auto IV (PS3)" },
                    { 4, new Guid("51175125-eef4-40ee-9f81-29e751cf6b08"), 2008, 98.900000000000006, "Grand Theft Auto IV (X360)" },
                    { 5, new Guid("e2a64cc4-a0b6-4aee-8604-fdf0f910f2dc"), 1999, 98.900000000000006, "SoulCalibur (DC)" },
                    { 6, new Guid("dea160f7-ec16-41ce-bb44-775da9c01ba7"), 2007, 97.900000000000006, "Super Mario Galaxy (WII)" }
                });

            migrationBuilder.CreateIndex(
                name: "IDX_GUID",
                table: "Game",
                column: "EntidadeGameGuid",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
