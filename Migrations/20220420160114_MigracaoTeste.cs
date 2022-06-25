using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoErr.Migrations
{
    public partial class MigracaoTeste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    IdMarca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dsMarca = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.IdMarca);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataAcesso = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMarca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClasseEnum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "IdMarca", "dsMarca" },
                values: new object[,]
                {
                    { 1, "Renault" },
                    { 2, "Fiat" },
                    { 3, "Honda" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "DataAcesso", "Foto", "Latitude", "Longitude", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, null, null, "", "", new byte[] { 130, 38, 68, 20, 231, 112, 88, 154, 88, 63, 188, 186, 147, 119, 113, 104, 233, 51, 121, 153, 92, 228, 79, 242, 253, 143, 94, 77, 183, 229, 236, 167, 5, 113, 255, 28, 30, 135, 33, 8, 18, 65, 161, 55, 238, 132, 15, 177, 92, 11, 190, 98, 95, 122, 87, 192, 112, 118, 160, 8, 24, 191, 69, 34 }, new byte[] { 222, 220, 114, 248, 85, 33, 182, 134, 32, 127, 76, 78, 131, 5, 159, 244, 17, 110, 187, 59, 240, 124, 50, 190, 213, 176, 49, 52, 68, 5, 144, 206, 105, 32, 33, 105, 62, 163, 19, 200, 159, 68, 141, 79, 45, 199, 189, 44, 86, 243, 8, 132, 169, 138, 176, 140, 149, 204, 37, 51, 31, 88, 122, 0, 220, 209, 17, 90, 219, 125, 249, 38, 11, 141, 44, 55, 41, 106, 10, 172, 29, 232, 137, 6, 97, 188, 4, 250, 165, 117, 191, 238, 109, 74, 240, 83, 11, 27, 29, 90, 103, 232, 108, 15, 32, 4, 46, 92, 235, 175, 9, 65, 147, 250, 231, 238, 166, 252, 142, 73, 2, 21, 97, 100, 245, 93, 178, 18 }, "UsuarioAdmin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
